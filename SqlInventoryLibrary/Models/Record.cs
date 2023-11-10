using System;
using System.Collections.Generic;
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
    }
}
