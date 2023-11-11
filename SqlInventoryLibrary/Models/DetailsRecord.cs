using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SqlInventoryLibrary.Models
{
    public class DetailsRecord
    {
        private Product product;
        private int quantity;
        private double amount;

        public Product Product { get => product; set => product = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Amount { get => amount; set => amount = value; }
    }
}
