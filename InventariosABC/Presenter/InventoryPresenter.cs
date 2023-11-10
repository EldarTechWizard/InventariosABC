using InventariosABC.Views.InventoryTab;
using InventariosABC.Views.MainTab;
using SqlInventoryLibrary.Models;
using SqlInventoryLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventariosABC.Presenter
{
    public class InventoryPresenter
    {

        private IInventoryView view;
        private IInventorySqlRepository sqlRepository;
        public InventoryPresenter(IInventoryView view)
        {
            this.view = view;
            sqlRepository = new InventorySqlRepository();
        }
    }
}
