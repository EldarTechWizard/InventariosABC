using DevExpress.XtraGrid.Views.Grid;
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
        int ProductId { get; set; }
        string Description { get; set; }
        double SalePrice { get; set; }
        double Balance { get; set; }

        bool EditMode {  get; set; }

        event EventHandler SaveEvent;
        event EventHandler DeleteEvent;
        event EventHandler FolioChangedEvent;
        event EventHandler GridClickEvent;
        event EventHandler LoadEvent;
        event EventHandler ClearEvent;
        event RowCellClickEventHandler RightClickRowEvent;

        void SetDataGridSource(DataTable data);
        void ClearTextBox();
        void ChangeToEditMode(bool aux);
        void SelectedRow();

        void SelectedRowIndex(ref int Index);
    }
}
