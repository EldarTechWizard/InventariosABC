using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventariosABC.Views.ProductPickerTab
{
    public partial class ProductPickerView : Form, IProductPickerView
    {
        public ProductPickerView()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
        }

        private int productId;
        private string description;
        private double salePrice;
        private double balance;

        public int ProductId { get => productId; set => productId = value; }
        public string Description { get => lueDescription.Text; set => lueDescription.Text = value; }
        public double SalePrice { get => salePrice; set => salePrice = value; }
        public double Balance { get => balance; set => balance = value; }

        public event EventHandler ChooseEvent;
        public event KeyEventHandler KeyPressEvent;
        public event EventHandler LoadEvent;
        public event EventHandler TextChangeEvent;

        public void AssociateAndRaiseEvents()
        {
            btnChoose.Click += delegate { ChooseEvent?.Invoke(this, EventArgs.Empty); };
            this.Load += delegate { LoadEvent?.Invoke(this, EventArgs.Empty); };


            lueDescription.TextChanged += delegate { TextChangeEvent?.Invoke(this, EventArgs.Empty); };
            lueDescription.KeyDown += (s, e) =>
            {
                KeyPressEvent?.Invoke(s, e);
            };
        }

        public void SetDataGridSource(DataTable data)
        {
            gcProducts.DataSource = data;
        }

        public void TextEditSource(DataTable data)
        {
            lueDescription.Properties.DataSource = data;
            lueDescription.Properties.DisplayMember = "description";
            lueDescription.Properties.ValueMember = "productId";
        }

        public void FilterDataGrid()
        {
            if (!String.IsNullOrEmpty(lueDescription.Text))
            {
                gridView1.ActiveFilterString = $"Contains([description], '{lueDescription.Text}')";
            }
                                        
        }

        public void DisableFilterGrid()
        {
            if (String.IsNullOrEmpty(lueDescription.Text))
            {
                gridView1.ActiveFilterString = $"Contains([description], '')";
            }
        }

        public void CloseForm()
        {
            this.Close();
        }
    }
}
