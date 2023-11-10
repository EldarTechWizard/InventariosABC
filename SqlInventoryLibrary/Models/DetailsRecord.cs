using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SqlInventoryLibrary.Models
{
    public class DetailsRecord
    {
        private int productId;
        private string quantity;

        public string Quantity { get => quantity; set => quantity = value; }
        public int ProductId { get => productId; set => productId = value; }
    }
}
