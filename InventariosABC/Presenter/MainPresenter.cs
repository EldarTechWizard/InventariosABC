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
        private IInventorySqlRepository sqlRepository;
        public MainPresenter(IMainView view) 
        { 
            this.view = view;
            sqlRepository = new InventorySqlRepository();
        }


    }
}
