using DevExpress.XtraGrid.Views.Grid;
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
        private Dictionary<int, Product> products = new Dictionary<int, Product>();
        public ProductPresenter(IProductView view)
        {
            this.view = view;
            sqlRepository = new InventorySqlRepository();

            this.view.LoadEvent += LoadEvent;
            this.view.SaveEvent += SaveEvent;
            this.view.DeleteEvent += DeleteEvent;
            this.view.FolioChangedEvent += FolioChangedEvent;
            this.view.GridClickEvent += GridClickEvent;
            this.view.RightClickRowEvent += RightClickEvent;
            this.view.ClearEvent += ClearEvent;

        }

        private void ClearEvent(object sender, EventArgs e)
        {
            view.ClearTextBox();
            SetMaxFolio();
        }

        public void LoadEvent(object sender, EventArgs e)
        {
            GetAllProducts();
            SetMaxFolio();
        }
        public void SaveEvent(object sender, EventArgs e)
        {
            if (view.EditMode)
            {
                UpdateProduct();
            }
            else
            {
                InsertNewProduct();
            }
           
        }

        public void RightClickEvent(object sender, RowCellClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {                          
                GetSelectedRows();
                DeleteProduct();             
            }
        }
        public void DeleteEvent(object sender, EventArgs e)
        {
            DeleteProduct();
        }

        public void FolioChangedEvent(object sender, EventArgs e)
        {
            GetOneProduct();
        }

        public void GridClickEvent(object sender, EventArgs e)
        {
            GetSelectedRows();
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
                
                foreach(DataRow row in data.Rows)
                {
                    Product product = new Product();
                    product.ProductID = (int)row["productId"];
                    product.Description = row["description"].ToString();
                    product.SalePrice = double.Parse(row["salePrice"].ToString());
                    product.Balance = double.Parse(row["balance"].ToString());

                    products[product.ProductID] = product;
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
                if(products.ContainsKey(view.ProductId)) 
                {
                    view.Description = products[view.ProductId].Description;
                    view.SalePrice = products[view.ProductId].SalePrice;
                    view.Balance = products[view.ProductId].Balance;

                    view.ChangeToEditMode(true);
                }
                else
                {
                    view.ChangeToEditMode(false);
                    view.ClearTextBox();
                }
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
                    ProductID = view.ProductId,
                    Description = view.Description,
                    SalePrice = view.SalePrice,
                    Balance = view.Balance
                };

                if (!sqlRepository.InsertProducts(product))
                {
                    throw new Exception(sqlRepository.LastError);
                }

                GetAllProducts();
                view.ChangeToEditMode(true);

                MessageBox.Show("Producto insertado correctamente");
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
                if (!products.ContainsKey(view.ProductId))
                {
                    throw new Exception("Porfavor escriba un id valido");
                }

                products[view.ProductId].Description = view.Description;
                products[view.ProductId].SalePrice = view.SalePrice;

                if (!sqlRepository.UpdateProducts(products[view.ProductId]))
                {
                    throw new Exception(sqlRepository.LastError);
                }

                GetAllProducts();
                MessageBox.Show("Productos actualizado correctamente");
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
                if (!products.ContainsKey(view.ProductId))
                {
                    throw new Exception("Porfavor escriba un id valido");
                }

                DialogResult dialogResult = MessageBox.Show("Deshacer registro?", "Deshacer Registro", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                if (!sqlRepository.DeleteProduct(view.ProductId))
                {
                    throw new Exception(sqlRepository.LastError);
                }


                GetAllProducts();
                view.ClearTextBox();

                MessageBox.Show("Productos eliminado correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void SetMaxFolio()
        {
            try
            {
                int maxFolio = 0;
                if(!sqlRepository.GetMaxProductId(ref maxFolio))
                {
                    throw new Exception();
                }

                maxFolio++;

                view.ProductId = maxFolio;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetSelectedRows()
        {
            view.SelectedRow();
        }
    }
}
