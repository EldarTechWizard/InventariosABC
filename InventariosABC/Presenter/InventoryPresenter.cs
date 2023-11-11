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
        public InventoryPresenter(IInventoryView view)
        {
            this.view = view;
            sqlRepository = new InventorySqlRepository();
            this.view.SaveEvent += this.SaveEvent;
            this.view.DeleteEvent += this.DeleteEvent;
            this.view.ClearEvent += this.ClearEvent;
            this.view.FolioChangedEvent += this.FolioChangedEvent;
            this.view.KeyPressEvent += this.KeyPressEvent;

            DataTable dt = new DataTable();
            GetRecords(ref dt);
            GetProduct();
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

        }

        public void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                DetailsRecord detailsRecord = new DetailsRecord();
                detailsRecord.ProductId = view.productId;
                detailsRecord.Quantity = view.Quantity;
            
                DetailsList.Add(detailsRecord);


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
                    record.Total = (double)row["total"];
                    record.MovementType = row["movementType"].ToString();

                    records.Add(record.Folio, record);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }           
        }

        public void GetProduct()
        {
            try
            {
                DataTable dataTable = new DataTable();

                if(sqlRepository.GetAllProducts(ref dataTable))
                {
                    throw new Exception(sqlRepository.LastError);
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    Product product = new Product();

                    product.ProductID = (int)row["productId"];
                    product.Description = row["description"].ToString();
                    product.SalePrice = (double)row["salePrice"];
                    product.Balance = (double)row["balance"];
                }

                //Agregar el lookUpEdit
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void UpdateDataGrid()
        {
            try
            {
                DataTable data = new DataTable();
                GetRecords(ref data);
                view.SetDataSourceDataGrid(data);
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
                record.DetailsRecords = DetailsList; // Programar el evento keyPress "Enter" para agregar productos a la lista 

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

        public void CleanFolio()
        {
            //Programar los textBox primero
        }


        public void CalculateSaleAmount(ref int salesAmount)
        {
            int quantity = view.Quantity;
            double salePrice = view.SalesPrice;

            salesAmount = salesAmount * quantity;
        }


        
    }
}
