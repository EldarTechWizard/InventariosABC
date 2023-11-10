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



            DataTable dt = new DataTable();
            GetRecords(ref dt);
            GetProduct();
        }

        public void GetRecords(ref DataTable data)
        {
            sqlRepository.GetAllRegisters(ref data);

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

        public void GetProduct()
        {
            DataTable dataTable = new DataTable();
            sqlRepository.GetAllProducts(ref dataTable);

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

        public void UpdateDataGrid()
        {
            DataTable data = new DataTable();
            GetRecords(ref data);
            view.SetDataSourceDataGrid(data);
        }

        public void SaveFolio()
        {
            Record record = new Record();

            record.Folio = view.Folio;
            record.Date = view.Date;
            record.MovementType = view.MovementType;
            record.Total = view.TotalAmount;
            record.DetailsRecords = DetailsList; // Programar el evento keyPress "Enter" para agregar productos a la lista 

            sqlRepository.InsertNewsRegisters(record);
        }

        public void DeleteFolio()
        {
            sqlRepository.DeleteRegisters(view.Folio);
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
