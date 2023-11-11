using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventariosABC.Presenter;
using InventariosABC.Views.InventoryTab;
using InventariosABC.Views.MainTab;
namespace InventariosABC
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            IInventoryView Iview = new InventoryView();
            new InventoryPresenter(Iview);


            Application.Run((Form)Iview);
        }
    }
}
