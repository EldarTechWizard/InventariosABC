using DevExpress.XtraGrid.Views.Grid;
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
            AssociateAndRaiseEvents();
        }

        private bool editMode = false;
        public int ProductId { 
            get {
                int value = 0;

                if(int.TryParse(tbProductId.Text,out value))
                {
                    return value;
                }

                return 0;
            } set => tbProductId.Text = value.ToString(); }
        public string Description { get => tbDescription.Text; set => tbDescription.Text = value; }
        public double SalePrice { get => double.Parse(tbSalePrice.Text); set => tbSalePrice.Text = value.ToString(); }
        public double Balance { get => double.Parse(tbBalance.Text); set => tbBalance.Text = value.ToString(); }
        public bool EditMode { get => editMode; set => editMode = value; }

        public event EventHandler SaveEvent;
        public event EventHandler LoadEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler ClearEvent;
        public event EventHandler FolioChangedEvent;
        public event EventHandler GridClickEvent;
        public event RowCellClickEventHandler RightClickRowEvent;

        private void AssociateAndRaiseEvents()
        {
            this.Load += delegate { LoadEvent?.Invoke(this, EventArgs.Empty); };
            btnSave.Click += delegate { SaveEvent?.Invoke(this, EventArgs.Empty); };
            btnDelete.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };
            tbProductId.TextChanged += delegate { FolioChangedEvent?.Invoke(this, EventArgs.Empty); };
            btnClear.Click += delegate { ClearEvent?.Invoke(this, EventArgs.Empty); };
            gridView1.Click += delegate { GridClickEvent?.Invoke(this, EventArgs.Empty); };
            gridView1.RowCellClick += (s, e) =>
            {
                RightClickRowEvent?.Invoke(s, e);
            };
        }
        public void ChangeToEditMode(bool aux)
        {
            if (aux)
            {
                btnSave.Text = "Editar";
                tbBalance.ReadOnly = true;
                editMode = true;
            }
            else
            {
                btnSave.Text = "Agregar";
                tbBalance.ReadOnly = false;
                editMode = false;
            }
        }

        public void ClearTextBox()
        {
            tbDescription.Text = string.Empty;
            tbBalance.Text = "0";
            tbSalePrice.Text = "0";
        }

        public void SelectedRow()
        {
            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);
                this.ProductId = (int)row["productId"];
                this.Description = row["description"].ToString();
                this.SalePrice = double.Parse(row["salePrice"].ToString());
                this.Balance = double.Parse(row["balance"].ToString());
            }
        }

        public void SetDataGridSource(DataTable data)
        {
           gcProducts.DataSource = data;
        }

        public void SelectedRowIndex(ref int Index)
        {
            foreach (int i in gridView1.GetSelectedRows())
            {
                Index = i;
            }
        }
    }
}
