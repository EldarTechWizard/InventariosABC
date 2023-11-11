using DevExpress.XtraEditors.Repository;
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

namespace InventariosABC.Views.InventoryTab
{
    public partial class InventoryView : Form, IInventoryView
    {
        public InventoryView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            dpDate.Format = DateTimePickerFormat.Custom;
            dpDate.CustomFormat = "MM/dd/yyyy";

        }

        public void AssociateAndRaiseViewEvents()
        {
            btnSave.Click += delegate { SaveEvent?.Invoke(this, EventArgs.Empty); };
            btnDelete.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };
            btnClear.Click += delegate { ClearEvent?.Invoke(this, EventArgs.Empty); };
            Load += delegate { LoadEvent?.Invoke(this, EventArgs.Empty); };

            tbFolio._TextChanged += delegate { FolioChangedEvent?.Invoke(this, EventArgs.Empty); };
            lueDescription.EditValueChanged += delegate { DescriptionChanged?.Invoke(this, EventArgs.Empty); };

            this.KeyDown += (s, e) =>
            {
                KeyPressEvent?.Invoke(s, e);
            };

            btnInsert.Click += delegate { InsertEvent?.Invoke(this, EventArgs.Empty); };
        }



        private double balance = 0;

        public int Folio { 
            get  {
                int result = 0;

                if (int.TryParse(tbFolio.Texts,out result))
                {
                    return result;
                }

                return 0;          
            
            } set => tbFolio.Texts = value.ToString(); 
        }

        public string Date { get => dpDate.Text; set => dpDate.Text = value;}
        public string MovementType { get => cbMovementType.Text; set => cbMovementType.Text = value; }
        public int ProductId { get => int.Parse(tbProductId.Texts); set => tbProductId.Texts = value.ToString(); }
        public string Description { get => lueDescription.Text; set => lueDescription.Text = value; }
        public int Quantity { get => int.Parse(tbQuantity.Texts); set => tbQuantity.Texts = value.ToString(); }
        public double SalesPrice { get => double.Parse(tbSalePrice.Texts); set => tbSalePrice.Texts = value.ToString(); }
        public double TotalAmount { get => double.Parse(tbTotal.Texts); set => tbTotal.Texts = value.ToString(); }
        public string EditValue { get => lueDescription.EditValue.ToString(); set => lueDescription.EditValue = value; }
        public double Balance { get => balance; set => balance = value; }

        public event EventHandler SaveEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler ClearEvent;
        public event EventHandler FolioChangedEvent;
        public event KeyEventHandler KeyPressEvent;
        public event EventHandler LoadEvent;
        public event EventHandler DescriptionChanged;
        public event EventHandler InsertEvent;

        public void SetDataSourceDataGrid(DataTable data)
        {
            gcRecords.DataSource = data;
        }

        public void AddNewRowDataGrid()
        {
            DataTable data = gcRecords.DataSource as DataTable;
            DataRow dataRow = data.NewRow();

            dataRow["productId"] = this.ProductId;
            dataRow["description"] = this.Description;
            dataRow["quantity"] = this.Quantity;
            dataRow["salePrice"] = this.SalesPrice;
            dataRow["amount"] = this.SalesPrice * this.Quantity;

            data.Rows.Add(dataRow);
        }

        public void ClearAllTextBox()
        {
            tbFolio.Texts = string.Empty;
            tbProductId.Text = string.Empty;
            tbQuantity.Texts = string.Empty;
            tbSalePrice.Texts = string.Empty;
            tbTotal.Texts = string.Empty;
            dpDate.Text = string.Empty;
            cbMovementType.Text = string.Empty;
            lueDescription.Text = string.Empty;
        }

        public void ClearProducTextBox()
        {
            tbProductId.Texts = string.Empty;
            tbQuantity.Texts = string.Empty;
            lueDescription.Text = string.Empty;
            tbSalePrice.Texts = string.Empty;   
        }

        public void SetDataSourceLookUpEdit(DataTable data)
        {
            lueDescription.Properties.DataSource = data;
            lueDescription.Properties.DisplayMember = "description";
            lueDescription.Properties.ValueMember = "productId";
        }
    }
}
