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
        private int quantity;

        public int Quantity { get => quantity; set => quantity = value; }
        public int ProductId { get => productId; set => productId = value; }
    }
}
