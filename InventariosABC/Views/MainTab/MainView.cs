using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventariosABC.Presenter;
using InventariosABC.Views;
using InventariosABC.Views.ProductsTab;
using InventariosABC.Views.InventoryTab;

namespace InventariosABC.Views.MainTab
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            AssociateAndRaisedEvents();
        }


        public int activateTab = 1;
        public bool isInstanceActive = false;
        public bool IsInstanceActive { get => IsInstanceActive; set => isInstanceActive = true; }
        public int ActiveTab { get => tabPane1.SelectedPageIndex; set => tabPane1.SelectedPageIndex = value; }

        public event EventHandler loadEvent;
        public event EventHandler openTab;
        public event EventHandler openProductTab;

        public void AssociateAndRaisedEvents()
        {
            tabPane1.SelectedPageChanged += delegate { openTab?.Invoke(this, EventArgs.Empty); };
            this.loadEvent += delegate { loadEvent?.Invoke(this, EventArgs.Empty); };
        }


        public void ShowInventoryInstance()
        {
            tabPane1.SelectedPage.Controls.Clear();

            IInventoryView view = new InventoryView();
            new InventoryPresenter(view);
            Form form = (Form)view;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.Show();


            tabPane1.SelectedPage.Controls.Add(form);
        }

        public void ShowProductInstance()
        {
            tabPane1.SelectedPage.Controls.Clear();

            IProductView view = new ProductView();
            new ProductPresenter(view);
            Form form = (Form)view;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.Show();

            tabPane1.SelectedPage.Controls.Add(form);
        }
    }
}
