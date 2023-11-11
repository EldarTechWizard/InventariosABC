using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventariosABC.Views.InventoryTab
{
    public partial class InventoryView : Form, IInventoryView
    {
        public InventoryView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        public void AssociateAndRaiseViewEvents()
        {
            btnSave.Click += delegate { SaveEvent?.Invoke(this, EventArgs.Empty); };
            btnDelete.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };
            btnClear.Click += delegate { ClearEvent?.Invoke(this, EventArgs.Empty); };

            tbFolio._TextChanged += delegate { FolioChangedEvent?.Invoke(this, EventArgs.Empty); };

            this.KeyPress += (s, e) =>
            {
                KeyPressEvent?.Invoke(s, e);
            };
        }


        public int Folio { get => int.Parse(tbFolio.Texts); set => tbFolio.Texts = value.ToString(); }
        public string Date { get => dpDate.Text; set => dpDate.Text = value;}
        public string MovementType { get => drpDwnBtnMovement.Text; set => drpDwnBtnMovement.Text = value; }
        public int productId { get => int.Parse(tbProductId.Texts); set => tbProductId.Texts = value.ToString(); }
        public string Description { get => lueDescription.Text; set => lueDescription.Text = value; }
        public int Quantity { get => int.Parse(tbQuantity.Texts); set => tbQuantity.Texts = value.ToString(); }
        public double SalesPrice { get => double.Parse(tbSalePrice.Texts); set => tbSalePrice.Texts = value.ToString(); }
        public double TotalAmount { get => double.Parse(tbTotal.Texts); set => tbTotal.Texts = value.ToString(); }
        
        

        public event EventHandler SaveEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler ClearEvent;
        public event EventHandler FolioChangedEvent;
        public event KeyPressEventHandler KeyPressEvent;

        public void SetDataSourceDataGrid(DataTable data)
        {
            gcRecords.DataSource = data;
        }
    }
}
