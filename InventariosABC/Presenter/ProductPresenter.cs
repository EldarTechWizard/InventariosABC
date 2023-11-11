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
using System.Windows.Forms;

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
            try
            {
                DataTable data = new DataTable();
                if(!sqlRepository.GetAllProducts(ref data))
                {
                    throw new Exception(sqlRepository.LastError);
                }

                view.SetDataGridSource(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void GetOneProduct()
        {
            try
            {
                Product product = new Product
                {
                    ProductID = view.productId
                };

                if(!sqlRepository.GetOneProduct(ref product))
                {
                    throw new Exception(sqlRepository.LastError);
                }

                view.description = view.description;
                view.SalePrice = view.SalePrice;
                view.Balance = view.Balance;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void InsertNewProduct()
        {
            try
            {
                Product product = new Product
                {
                    ProductID = view.productId,
                    Description = view.description,
                    SalePrice = view.SalePrice,
                    Balance = view.Balance
                };

                sqlRepository.InsertProducts(product);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void UpdateProduct()
        {
            try
            {
                Product product = new Product
                {
                    ProductID = view.productId,
                    Description = view.description,
                    SalePrice = view.SalePrice,
                    Balance = view.Balance
                };

                if (!sqlRepository.UpdateProducts(product))
                {
                    throw new Exception(sqlRepository.LastError);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void DeleteProduct()
        {
            try
            {
                Product product = new Product
                {
                    ProductID = view.productId
                };

                if (!sqlRepository.DeleteProduct(product.ProductID))
                {
                    throw new Exception(sqlRepository.LastError);
                }


                GetAllProducts();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
