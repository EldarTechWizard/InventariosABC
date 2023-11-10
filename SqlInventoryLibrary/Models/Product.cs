using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlInventoryLibrary.Models
{
    public class Product
    {
        private int productID;
        private string description;
        private double salePrice;
        private double balance;

        public int ProductID { get => productID; set => productID = value; }
        public string Description { get => description; set => description = value; }
        public double SalePrice { get => salePrice; set => salePrice = value; }
        public double Balance { get => balance; set => balance = value; }
    }
}
