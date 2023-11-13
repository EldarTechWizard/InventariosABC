using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventariosABC.Views.ProductPickerTab
{
    public interface IProductPickerView
    {
        int ProductId { get; set; }
        string Description { get; set; }
        double SalePrice { get; set; }
        double Balance {  get; set; }

        event EventHandler ChooseEvent;
        event EventHandler LoadEvent;
        event KeyEventHandler KeyPressEvent;
        event EventHandler TextChangeEvent;

        void SetDataGridSource(DataTable data);
        void TextEditSource(DataTable data);

        void DisableFilterGrid();

        void CloseForm();

        void FilterDataGrid();


    }
}
