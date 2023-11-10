using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using SqlInventoryLibrary.Models;

namespace SqlInventoryLibrary.Repository
{
    public class InventorySqlRepository : IInventorySqlRepository
    {
        private string connectionString;
        private string lastError;


        string IInventorySqlRepository.LastError => lastError;

        public InventorySqlRepository() 
        { 
            this.connectionString = Properties.Settings.Default["StrConn"].ToString();
        }


        public bool InsertNewsRegisters(Record record)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString)) 
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    SqlTransaction transaction = conn.BeginTransaction();
                    conn.Open();

                    try
                    {                                              
                        cmd.Transaction = transaction;
                        cmd.Connection = conn;

                        cmd.CommandText = "insert into inventory (folio, entryDate, total, movementType) values (@folio,@entryDate,@total,@movementType)";
                        cmd.Parameters.AddWithValue("@folio", record.Folio);
                        cmd.Parameters.AddWithValue("@entryDate", record.Date);
                        cmd.Parameters.AddWithValue("@total", record.Total);
                        cmd.Parameters.AddWithValue("@movementType", record.MovementType);
                        cmd.ExecuteNonQuery();
                        
                        foreach (DetailsRecord details in record.DetailsRecords)
                        {
                            cmd.CommandText = "insert into inventoryDetails (folio, productId, quantity) values (@folio,@productId,@quantity)";
                            cmd.Parameters.AddWithValue("@folio", record.Folio);
                            cmd.Parameters.AddWithValue("@productId", details.ProductId);
                            cmd.Parameters.AddWithValue("@quantity", details.Quantity);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception(ex.Message);
                    }

                }

                return true;

            }catch (Exception ex)
            {
                lastError = ex.Message;
                return false;
            }
        }

        public bool DeleteRegisters(int folio)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    SqlTransaction transaction = conn.BeginTransaction();
                    conn.Open();
                    try
                    {
                        cmd.Transaction = transaction;
                        cmd.Connection = conn;

                        cmd.CommandText = "delete from inventoryDetails where folio = @folio";
                        cmd.Parameters.AddWithValue("@folio", folio);
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "delete from inventory where folio = @folio";
                        cmd.Parameters.AddWithValue("@folio", folio);
                        cmd.ExecuteNonQuery();

                        transaction.Commit();

                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception(ex.Message);
                    }

                }

                return true;

            }
            catch (Exception ex)
            {
                lastError = ex.Message;
                return false;
            }
        }

        public bool GetAllRegisters(ref DataTable data)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = $"Select * from inventory";
                    data.Load(cmd.ExecuteReader());
                }

                return true;

            }
            catch (Exception ex)
            {
                lastError = ex.Message;
                return false;
            }
        }
        public bool GetAllTransactionData(ref DataTable data, int folio)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = $"select id.productId, p.description, id.quantity, p.salePrice, (p.salePrice * id.quantity) as amount from inventoryDetails id join products p on id.productId = p.productId where id.folio = @folio";
                    cmd.Parameters.AddWithValue("@folio", folio);
                    data.Load(cmd.ExecuteReader());

                }
                return true;
            }
            catch (Exception ex)
            {
                lastError = ex.Message;
                return false;
            }
        }
        public bool GetAllProducts (ref DataTable data)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from products";
                    data.Load(cmd.ExecuteReader());

                }
                return true;
            }
            catch (Exception ex)
            {
                lastError = ex.Message;
                return false;
            }
        }

        public bool InsertProducts(Product product)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into products (productId, description, salePrice, balance) values (@productId,@description,@salePrice,@balance)";
                    cmd.Parameters.AddWithValue("@productId", product.ProductID);
                    cmd.Parameters.AddWithValue("@description", product.Description);
                    cmd.Parameters.AddWithValue("@salePrice", product.SalePrice);
                    cmd.Parameters.AddWithValue("@balance", product.Balance);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                lastError = ex.Message;
                return false;
            }
        }

        public bool DeleteProduct(int productID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "delete from products where productId = @productId";
                    cmd.Parameters.AddWithValue("@productId", productID);
                    cmd.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception ex)
            {
                lastError = ex.Message;
                return false;
            }
        }

        public bool UpdateProducts(Product product)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "update products set description = @description, salePrice = @salePrice  where productId = @productId";
                    cmd.Parameters.AddWithValue("@productId", product.ProductID);
                    cmd.Parameters.AddWithValue("@description", product.Description);
                    cmd.Parameters.AddWithValue("@salePrice", product.SalePrice);
                    cmd.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception ex)
            {
                lastError = ex.Message;
                return false;
            }
        }

        public bool GetOneProduct(ref Product product)
        {
            try
            {   
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "Select * from products where productId = @productId";
                    cmd.Parameters.AddWithValue("@productId", product.ProductID);
                    dt.Load(cmd.ExecuteReader());

                    product.Description = dt.Rows[0]["description"].ToString();
                    product.SalePrice = (double)dt.Rows[0]["salePrice"];
                    product.Balance = (double)dt.Rows[0]["balance"];
                }
                return true;
            }
            catch (Exception ex)
            {
                lastError = ex.Message;
                return false;
            }
        }
    }
}
