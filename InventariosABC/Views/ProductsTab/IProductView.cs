using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventariosABC.Views.ProductsTab
{
    public interface IProductView
    {
        int productId { get; set; }
        string description { get; set; }
        double SalePrice { get; set; }
        double Balance { get; set; }

        event EventHandler SaveEvent;
        event EventHandler EditEvent;
        event EventHandler FolioChangedEvent;
        event DataGridViewCellMouseEventHandler RightClickEvent;

        void SetDataGridSource(DataTable data);

    }
}
