namespace InventariosABC.Views.MainTab
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.InventoryTab = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.ProductTab = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.InventoryTab);
            this.tabPane1.Controls.Add(this.ProductTab);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.LookAndFeel.SkinMaskColor = System.Drawing.Color.SteelBlue;
            this.tabPane1.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.tabPane1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.InventoryTab,
            this.ProductTab});
            this.tabPane1.RegularSize = new System.Drawing.Size(747, 781);
            this.tabPane1.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.WhenNotFloating;
            this.tabPane1.SelectedPage = this.ProductTab;
            this.tabPane1.Size = new System.Drawing.Size(747, 781);
            this.tabPane1.TabIndex = 0;
            // 
            // InventoryTab
            // 
            this.InventoryTab.Caption = "Inventario ABC";
            this.InventoryTab.Name = "InventoryTab";
            this.InventoryTab.Size = new System.Drawing.Size(747, 746);
            // 
            // ProductTab
            // 
            this.ProductTab.Caption = "ProductCRUD";
            this.ProductTab.Name = "ProductTab";
            this.ProductTab.Size = new System.Drawing.Size(747, 746);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 781);
            this.Controls.Add(this.tabPane1);
            this.Name = "MainView";
            this.Text = "MainView";
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage InventoryTab;
        private DevExpress.XtraBars.Navigation.TabNavigationPage ProductTab;
    }
}