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

        public int productId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double SalePrice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Balance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
