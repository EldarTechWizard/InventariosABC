using InventariosABC.Views.InventoryTab;
using InventariosABC.Views.MainTab;
using SqlInventoryLibrary.Models;
using SqlInventoryLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventariosABC.Presenter
{
    public class InventoryPresenter
    {

        private IInventoryView view;
        private IInventorySqlRepository sqlRepository;
        private Dictionary<int,Record> records = new Dictionary<int,Record>();
        private List<DetailsRecord> DetailsList = new List<DetailsRecord>();
        private Dictionary<int,Product> productList = new Dictionary<int,Product>();
        public InventoryPresenter(IInventoryView view)
        {
            this.view = view;
            sqlRepository = new InventorySqlRepository();
            this.view.SaveEvent += this.SaveEvent;
            this.view.DeleteEvent += this.DeleteEvent;
            this.view.ClearEvent += this.ClearEvent;
            this.view.FolioChangedEvent += this.FolioChangedEvent;
            this.view.KeyPressEvent += this.KeyPressEvent;
            this.view.LoadEvent += this.LoadEvent;
            this.view.DescriptionChanged += this.DescriptionChanged;
            this.view.InsertEvent += this.InsertEvent;
        }

        public void LoadEvent(object sender, EventArgs e)
        {
            GetProducts();
            DataTable dt = new DataTable();
            GetRecords(ref dt);

            DataTable data = new DataTable();
            data.Columns.Add("productId", typeof(String));
            data.Columns.Add("description", typeof(String));
            data.Columns.Add("quantity", typeof(double));
            data.Columns.Add("salePrice", typeof(double));
            data.Columns.Add("amount", typeof(double));
            view.SetDataSourceDataGrid(data);
        }

        public void SaveEvent(object sender, EventArgs e)
        {
            SaveFolio();
        }

        public void DeleteEvent(object sender, EventArgs e)
        {
            DeleteFolio();
        }
        public void ClearEvent(object sender, EventArgs e)
        {
            CleanFolio();
        }
        public void FolioChangedEvent(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        public void DescriptionChanged(object sender, EventArgs e)
        {
            AutoFillTextBox();
        }

        public void InsertEvent(object sender, EventArgs e)
        {
            DetailsRecord detailsRecord = new DetailsRecord();
            Product product = new Product();
            product.ProductID = view.ProductId;
            product.SalePrice = view.SalesPrice;
            product.Description = view.Description;

            detailsRecord.Product = product;
            detailsRecord.Quantity = view.Quantity;
            detailsRecord.Amount = view.Quantity * product.SalePrice;

            view.TotalAmount += detailsRecord.Amount;

            DetailsList.Add(detailsRecord);

            AddNewRowDG();

            view.ClearAllTextBox();
        }

        public void KeyPressEvent(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                
            }
        }


        public void GetRecords(ref DataTable data)
        {
            try
            {
                if(!sqlRepository.GetAllRegisters(ref data))
                {
                    throw new Exception(sqlRepository.LastError);
                }

                foreach (DataRow row in data.Rows)
                {
                    Record record = new Record();

                    record.Folio = (int)row["folio"];
                    record.Date = row["entryDate"].ToString();
                    record.Total = double.Parse(row["total"].ToString());
                    record.MovementType = row["movementType"].ToString();

                    records.Add(record.Folio, record);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }           
        }

        public void GetProducts()
        {
            try
            {
                DataTable dataTable = new DataTable();

                if(!sqlRepository.GetAllProducts(ref dataTable))
                {
                    throw new Exception(sqlRepository.LastError);
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    Product product = new Product();

                    product.ProductID = (int)row["productId"];
                    product.Description = row["description"].ToString();
                    product.SalePrice = double.Parse(row["salePrice"].ToString());
                    product.Balance = double.Parse(row["balance"].ToString());

                    productList.Add(product.ProductID, product);
                }

                view.SetDataSourceLookUpEdit(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void AddNewRowDG()
        {
            try
            {
                view.AddNewRowDataGrid();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateDataGrid()
        {
            try
            {
                DataTable data = new DataTable();

                if(!records.ContainsKey(view.Folio))
                {
                    return;
                }


                if(!sqlRepository.GetAllTransactionData(ref data, view.Folio))
                {
                    throw new Exception(sqlRepository.LastError);
                }

                view.SetDataSourceDataGrid(data);
                view.ClearProducTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void SaveFolio()
        {
            try
            {
                Record record = new Record();

                record.Folio = view.Folio;
                record.Date = view.Date;
                record.MovementType = view.MovementType;
                record.Total = view.TotalAmount;
                record.DetailsRecords = DetailsList;  

                sqlRepository.InsertNewsRegisters(record);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void DeleteFolio()
        {
            try
            {
                if (!sqlRepository.DeleteRegisters(view.Folio))
                {
                    throw new Exception(sqlRepository.LastError);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void AutoFillTextBox()
        {
            try
            {
                Product product = productList[int.Parse(view.EditValue)];
                view.ProductId = product.ProductID;
                view.SalesPrice = product.SalePrice;
                view.Balance = product.Balance;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void CleanFolio()
        {
            view.ClearAllTextBox();
        }

        
    }
}
