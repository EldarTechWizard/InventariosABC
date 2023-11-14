using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventariosABC.Views;
using InventariosABC.Views.MainTab;
using SqlInventoryLibrary.Models;
using SqlInventoryLibrary.Repository;

namespace InventariosABC.Presenter
{
    public class MainPresenter
    {
        private IMainView view;
        public MainPresenter(IMainView view) 
        { 
            this.view = view;
            this.view.openTab += openTab;
            this.view.loadEvent += loadEvent;
                 
        }

        public void loadEvent(object sender, EventArgs e)
        {
            
        }

        public void openTab(object sender, EventArgs e)
        {
            if(view.ActiveTab == 0)
            {
                view.ShowInventoryInstance();
            }
            else
            {
                view.ShowProductInstance();
            }
            
        }

    }
}
