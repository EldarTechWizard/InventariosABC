using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventariosABC.Views.InventoryTab
{
    public interface IInventoryView
    {
        int Folio {  get; set; }
        string Date { get; set; }
        string MovementType { get; set; }
        int productId { get; set; }
        string Description { get; set; }
        int Quantity { get; set; }       
        double SalesPrice { get; set; }

        double TotalAmount { get; set; }

        event EventHandler SaveEvent;
        event EventHandler DeleteEvent;
        event EventHandler ClearEvent;
        event EventHandler FolioChangedEvent;
        event KeyPressEventHandler KeyPressEvent;

        void SetDataSourceDataGrid(DataTable data);
    }
}
