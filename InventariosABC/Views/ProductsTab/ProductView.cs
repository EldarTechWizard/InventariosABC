using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventariosABC.Views.ProductsTab
{
    public partial class ProductView : Form, IProductView
    {
        public ProductView()
        {
            InitializeComponent();
        }

        public int productId { get => int.Parse(tbProductId.Texts); set => tbProductId.Texts = value.ToString(); }
        public string description { get => tbDescription.Texts; set => tbDescription.Texts = value; }
        public double SalePrice { get => double.Parse(tbSalePrice.Texts); set => tbSalePrice.Texts = value.ToString(); }
        public double Balance { get => double.Parse(tbBalance.Texts); set => tbBalance.Texts = value.ToString(); }

        public event EventHandler SaveEvent;
        public event EventHandler EditEvent;
        public event EventHandler FolioChangedEvent;
        public event DataGridViewCellMouseEventHandler RightClickEvent;

        public void SetDataGridSource(DataTable data)
        {
            throw new NotImplementedException();
        }
    }
}
