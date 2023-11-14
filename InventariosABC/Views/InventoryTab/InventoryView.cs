using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
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
            dpDate.CustomFormat = "dd/MM/yyyy";
            this.KeyPreview = true;

        }

        public void AssociateAndRaiseViewEvents()
        {
            btnSave.Click += delegate { SaveEvent?.Invoke(this, EventArgs.Empty); };
            btnDelete.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };
            btnClear.Click += delegate { ClearEvent?.Invoke(this, EventArgs.Empty); };
            Load += delegate { LoadEvent?.Invoke(this, EventArgs.Empty); };

            tbFolio.TextChanged += delegate { FolioChangedEvent?.Invoke(this, EventArgs.Empty); };
            
            lueDescription.EditValueChanged += delegate { DescriptionChanged?.Invoke(this, EventArgs.Empty); };

            tbProductId.KeyDown += (s, e) =>
            {
                KeyDownEvent?.Invoke(s, e);
            };

            tbQuantity.KeyPress += (s, e) =>
            {
                KeyPressEvent?.Invoke(s, e);
            };


            gridView1.RowCellClick += (s, e) =>
            {
                RightClickRowEvent?.Invoke(s, e);
            };

            btnInsert.Click += delegate { InsertEvent?.Invoke(this, EventArgs.Empty); };
        }



        private double balance = 0;
        private bool folioExits = false;

        public int Folio 
        { 
            get  
            {
                int result = 0;

                if (int.TryParse(tbFolio.Text,out result))
                {
                    return result;
                }

                return 0;          
            
            } 
            
            set => tbFolio.Text = value.ToString(); 
        }

        public string Date { get => dpDate.Text; set => dpDate.Text = value;}
        public string MovementType { get => cbMovementType.Text; set => cbMovementType.Text = value; }
        public int ProductId { get => int.Parse(tbProductId.Text); set => tbProductId.Text = value.ToString(); }
        public string Description { get => lueDescription.Text; set => lueDescription.Text = value; }
        public int Quantity 
        {
            get 
            {
                int result = 0;

                if (int.TryParse(tbQuantity.Text, out result))
                {
                    return result;
                }

                return 0;
            }


            set => tbQuantity.Text = value.ToString(); 
        }
        public double SalesPrice { get => double.Parse(tbSalePrice.Text); set => tbSalePrice.Text = value.ToString(); }
        public double TotalAmount { get => double.Parse(tbTotal.Text); set => tbTotal.Text = value.ToString(); }
        public string EditValue { get => lueDescription.EditValue.ToString(); set => lueDescription.EditValue = value; }
        public double Balance { get => balance; set => balance = value; }
        public bool FolioExist { get => folioExits; set => folioExits = value; }

        public event EventHandler SaveEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler ClearEvent;
        public event EventHandler FolioChangedEvent;
        public event KeyEventHandler KeyDownEvent;
        public event EventHandler LoadEvent;
        public event EventHandler DescriptionChanged;
        public event EventHandler InsertEvent;
        public event KeyPressEventHandler KeyPressEvent;
        public event RowCellClickEventHandler RightClickRowEvent;

        public void SetDataSourceDataGrid(DataTable data)
        {
            gcRecords.DataSource = data;
        }

        public void AddNewRowDataGrid()
        {

            DataTable data = new DataTable();

            if (gcRecords.DataSource == null) 
            {
                
                data.Columns.Add("productId", typeof(String));
                data.Columns.Add("description", typeof(String));
                data.Columns.Add("quantity", typeof(double));
                data.Columns.Add("salePrice", typeof(double));
                data.Columns.Add("amount", typeof(double));
                SetDataSourceDataGrid(data);
            }

            data = gcRecords.DataSource as DataTable;
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
            tbFolio.Text = string.Empty;
            tbProductId.Text = string.Empty;
            tbQuantity.Text = "1";
            tbSalePrice.Text = string.Empty;
            tbTotal.Text = string.Empty;
            dpDate.Text = string.Empty;
            cbMovementType.Text = string.Empty;
            //lueDescription.Text = string.Empty;
        }

        public void ClearProducTextBox()
        {
            tbProductId.Text = string.Empty;
            tbQuantity.Text = "1";
            lueDescription.Text = string.Empty;
            tbSalePrice.Text = string.Empty;          
        }

        public void ClearIdTextBox()
        {
            tbProductId.Text = string.Empty;
        }

        public void SetDataSourceLookUpEdit(DataTable data)
        {
            lueDescription.Properties.DataSource = data;
            lueDescription.Properties.DisplayMember = "description";
            lueDescription.Properties.ValueMember = "productId";
        }

        public void SwicthStateMovementType(bool val)
        {
            if(val)
            {
                cbMovementType.ReadOnly = false;
            }
            else
            {
                cbMovementType.ReadOnly = true;
            }
        }

        public void UpdateProductQuantity()
        {
            DataTable data = new DataTable();
            data = gcRecords.DataSource as DataTable;

            foreach(DataRow row in data.Rows)
            {
                if (row["productId"].ToString() == this.ProductId.ToString())
                {
                    row["quantity"] = int.Parse(row["quantity"].ToString()) + this.Quantity;
                    row["amount"] = double.Parse(row["amount"].ToString()) + (this.Quantity * this.SalesPrice);
                }
            }
        }

        public void DeleteRowIndex(ref int index)
        {
            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);
                index = int.Parse(row["productId"].ToString());
                
            }
            gridView1.DeleteSelectedRows();
        }

        public void ChangeToReadOnlyMode(bool aux)
        {
            if (aux)
            {
                btnSave.Enabled = false;
                btnDelete.Enabled = true;
                folioExits = true;
            }
            else
            {
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
                folioExits = false;
            }
        }

        private void tbFolio_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            
           
        }
    }
}
