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
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();
                    
                    try
                    {                                              
                        cmd.Transaction = transaction;
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "spInsertInventory";
                        cmd.Parameters.AddWithValue("@folio", record.Folio);
                        cmd.Parameters.AddWithValue("@entryDate", record.Date);
                        cmd.Parameters.AddWithValue("@total", record.Total);
                        cmd.Parameters.AddWithValue("@movementType", record.MovementType);
                        cmd.ExecuteNonQuery();


                        cmd.CommandText = "spInsertInventoryDetails";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@tableInventoryDetails", record.DetailsRecordsDataTable);
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

            }catch (Exception ex)
            {
                lastError = ex.Message;
                return false;
            }
        }

        public bool DeleteRegisters(Record record)//Cambiar por datatable
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {

                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();
                   
                    try
                    {
                        cmd.Transaction = transaction;
                        cmd.Connection = conn;

                        cmd.CommandText = "delete from inventoryDetails where folio = @folio";
                        cmd.Parameters.AddWithValue("@folio", record.Folio);
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "delete from inventory where folio = @folio2";
                        cmd.Parameters.AddWithValue("@folio2", record.Folio);
                        cmd.ExecuteNonQuery();



                        int i = 0;
                        foreach (DetailsRecord details in record.DetailsRecords)
                        {
                            if (record.MovementType == "Entrada")
                            {
                                details.Product.Balance -= details.Quantity;
                                cmd.CommandText = $"update products set balance = @balance{i} where productId = @id{i}";
                                cmd.Parameters.AddWithValue($"@balance{i}", details.Product.Balance);
                                cmd.Parameters.AddWithValue($"@id{i}", details.Product.ProductID);
                                cmd.ExecuteNonQuery();
                            }
                            else if (record.MovementType == "Salida")
                            {
                                details.Product.Balance += details.Quantity;
                                cmd.CommandText = $"update products set balance = @balance{i} where productId = @id{i}";
                                cmd.Parameters.AddWithValue($"@balance{i}", details.Product.Balance);
                                cmd.Parameters.AddWithValue($"@id{i}", details.Product.ProductID);
                                cmd.ExecuteNonQuery();
                            }

                            i++;
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
                    cmd.CommandText = $"Select * from inventoryView";
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

        public bool GetRegister(ref DataTable data, int folio)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = $"Select * from inventoryView where folio = @folio";
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
        public bool GetAllTransactionData(ref DataTable data, int folio)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = $"select * from inventoryDetailsAndProductsView where folio = @folio";
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
                    cmd.CommandText = "select * from productsView";
                    cmd.CommandTimeout = 120;
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
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spInsertProduct";
                    cmd.CommandTimeout = 120;
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
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spDeleteProduct";
                    cmd.CommandTimeout = 120;
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
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spUpdateProducts";
                    cmd.CommandTimeout = 120;
                    cmd.Parameters.AddWithValue("@productId", product.ProductID);
                    cmd.Parameters.AddWithValue("@description", product.Description);
                    cmd.Parameters.AddWithValue("@balance", product.Balance);
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
                    cmd.CommandText = "Select * from productsView where productId = @productId";
                    cmd.CommandTimeout = 120;
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

        public bool GetMaxFolio(ref int maxFolio)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "select Max(Folio) FROM inventoryView";
                    cmd.CommandTimeout = 120;                  
                    dt.Load(cmd.ExecuteReader());

                    int.TryParse(dt.Rows[0][0].ToString(), out maxFolio);
                    

                }
                return true;
            }
            catch (Exception ex)
            {
                lastError = ex.Message;
                return false;
            }
        }

        public bool GetMaxProductId(ref int maxProductId)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "select Max(productId) FROM productsView";
                    cmd.CommandTimeout = 120;
                    dt.Load(cmd.ExecuteReader());

                    int.TryParse(dt.Rows[0][0].ToString(), out maxProductId);


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
