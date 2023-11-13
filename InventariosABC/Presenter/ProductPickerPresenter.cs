using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventariosABC.Views;
using InventariosABC.Views.ProductPickerTab;
using SqlInventoryLibrary;
using SqlInventoryLibrary.Models;
using SqlInventoryLibrary.Repository;

namespace InventariosABC.Presenter
{
    public class ProductPickerPresenter
    {

        private IInventorySqlRepository inventorySqlRepository;
        private IProductPickerView view;
        private Dictionary<string,Product> productList = new Dictionary<string,Product>();
        private Product product;
        public ProductPickerPresenter(IProductPickerView view) 
        { 
            inventorySqlRepository = new InventorySqlRepository ();
            this.view = view;
            this.view.LoadEvent += LoadEvent;
            this.view.ChooseEvent += ChooseEvent;
            this.view.KeyPressEvent += KeyPressEvent;
            this.view.TextChangeEvent += TextChangeEvent;
        }

        public void LoadEvent(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable ();

                if(!inventorySqlRepository.GetAllProducts(ref dataTable))
                {
                    throw new Exception(inventorySqlRepository.LastError);
                }

                view.SetDataGridSource(dataTable);


                
                foreach (DataRow row in dataTable.Rows)
                {
                    Product product = new Product
                    {
                        ProductID = (int)row["productId"],
                        Description = row["description"].ToString(),
                        SalePrice = double.Parse(row["salePrice"].ToString()),
                        Balance = double.Parse(row["balance"].ToString())
                    };

                    productList[product.Description] = product;
                   
                }

                view.TextEditSource(dataTable);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
        public void ChooseEvent(object sender, EventArgs e)
        {
            if (!productList.ContainsKey(view.Description))
            {
                MessageBox.Show("Debe elegir un producto en la lista o cerrar el formulario");
                return;
            }

            product = productList[view.Description];

            view.CloseForm();
        }

        public void KeyPressEvent(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back)
                view.DisableFilterGrid();
            else
                view.FilterDataGrid();
        }

        public void TextChangeEvent(object sender, EventArgs e)
        {
            if(productList.ContainsKey(view.Description))
            {
                view.ProductId = productList[view.Description].ProductID;
                view.SalePrice = productList[view.Description].SalePrice;
                view.Balance = productList[view.Description].Balance;
            }

            view.FilterDataGrid();
        }

        public Product GetResources()
        {
            return product;
        }
    }
}
