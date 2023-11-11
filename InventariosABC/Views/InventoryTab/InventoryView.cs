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
        }

        public int Folio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Date { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MovementType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Quantity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double SalesPrice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double TotalAmount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler SaveEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler ClearEvent;
        public event EventHandler FolioChangedEvent;
        public event KeyPressEventHandler KeyPressEvent;

        public void SetDataSourceDataGrid(DataTable data)
        {
            throw new NotImplementedException();
        }
    }
}
