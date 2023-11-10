using InventariosABC.Views.MainTab;
using InventariosABC.Views.ProductsTab;
using SqlInventoryLibrary.Models;
using SqlInventoryLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventariosABC.Presenter
{
    public class ProductPresenter
    {

        private IProductView view;
        private IInventorySqlRepository sqlRepository;
        public ProductPresenter(IProductView view)
        {
            this.view = view;
            sqlRepository = new InventorySqlRepository();
        }


    }
}
