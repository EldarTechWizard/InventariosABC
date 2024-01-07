using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SqlInventoryLibrary.Models
{
    public class Record
    {
        private int folio;
        private string date;
        private string movementType;
        private double total;
        List<DetailsRecord> detailsRecords;

        public int Folio { get => folio; set => folio = value; }
        public string Date { get => date; set => date = value; }
        public string MovementType { get => movementType; set => movementType = value; }     
        public double Total { get => total; set => total = value; }
        public List<DetailsRecord> DetailsRecords { get => detailsRecords; set => detailsRecords = value; }

        public DataTable DetailsRecordsDataTable 
        { 
            get 
            { 
                DataTable data = new DataTable();

                data.Columns.Add("folio", typeof(int));              
                data.Columns.Add("productId", typeof(int));
                data.Columns.Add("quantity", typeof(double));

                foreach (DetailsRecord detailsRecords in DetailsRecords) 
                { 
                    data.Rows.Add(folio,detailsRecords.Product.ProductID,detailsRecords.Quantity);
                }

                return data;
            } 
        }
    }
}
