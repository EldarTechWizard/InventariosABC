using InventariosABC.Views.MainTab;
using InventariosABC.Views.ProductsTab;
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
    public class ProductPresenter
    {

        private IProductView view;
        private IInventorySqlRepository sqlRepository;
        public ProductPresenter(IProductView view)
        {
            this.view = view;
            sqlRepository = new InventorySqlRepository();
        }

        public void GetAllProducts()
        {
            DataTable data = new DataTable();
            sqlRepository.GetAllProducts(ref data);

            view.SetDataGridSource(data);
        }

        public void GetOneProduct()
        {
            Product product = new Product();
            product.ProductID = view.productId;

            sqlRepository.GetOneProduct(ref product);

            view.description = view.description;
            view.SalePrice = view.SalePrice;
            view.Balance = view.Balance;
        }

        public void InsertNewProduct()
        {
            Product product = new Product();
            product.ProductID = view.productId;
            product.Description = view.description;
            product.SalePrice = view.SalePrice;
            product.Balance = view.Balance;

            sqlRepository.InsertProducts(product);
        }

        public void UpdateProduct()
        {
            Product product = new Product();
            product.ProductID = view.productId;
            product.Description = view.description;
            product.SalePrice= view.SalePrice;
            product.Balance= view.Balance;  

            sqlRepository.UpdateProducts(product);
        }

        public void DeleteProduct()
        {
            Product product = new Product();
            product.ProductID = view.productId;

            sqlRepository.DeleteProduct(product.ProductID);
            GetAllProducts();
        }
    }
}
