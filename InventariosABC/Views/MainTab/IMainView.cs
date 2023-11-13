using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventariosABC.Views.MainTab
{
    public interface IMainView
    {
        bool IsInstanceActive { get; set; }
        int ActiveTab {  get; set; }

        event EventHandler openTab;
        event EventHandler loadEvent;
        //event EventHandler openProductTab;

        void ShowInventoryInstance();
        void ShowProductInstance();
    }
}
