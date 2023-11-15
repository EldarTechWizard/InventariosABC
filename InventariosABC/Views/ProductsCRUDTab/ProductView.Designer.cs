namespace InventariosABC.Views.ProductsTab
{
    partial class ProductView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductView));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gcProducts = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tbProductId = new DevExpress.XtraEditors.TextEdit();
            this.tbSalePrice = new DevExpress.XtraEditors.TextEdit();
            this.tbDescription = new DevExpress.XtraEditors.TextEdit();
            this.tbBalance = new DevExpress.XtraEditors.TextEdit();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSalePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBalance.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "ProductoId:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Precio de venta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Saldo:";
            // 
            // gcProducts
            // 
            this.gcProducts.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcProducts.Location = new System.Drawing.Point(0, 236);
            this.gcProducts.MainView = this.gridView1;
            this.gcProducts.Name = "gcProducts";
            this.gcProducts.Size = new System.Drawing.Size(746, 311);
            this.gcProducts.TabIndex = 17;
            this.gcProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcProducts;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // tbProductId
            // 
            this.tbProductId.Location = new System.Drawing.Point(158, 45);
            this.tbProductId.Name = "tbProductId";
            this.tbProductId.Properties.Appearance.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductId.Properties.Appearance.Options.UseFont = true;
            this.tbProductId.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.tbProductId.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.tbProductId.Properties.MaskSettings.Set("mask", "\\d+");
            this.tbProductId.Properties.MaskSettings.Set("placeholder", '\0');
            this.tbProductId.Properties.MaskSettings.Set("allowBlankInput", true);
            this.tbProductId.Size = new System.Drawing.Size(179, 26);
            this.tbProductId.TabIndex = 1;
            // 
            // tbSalePrice
            // 
            this.tbSalePrice.EditValue = "0";
            this.tbSalePrice.Location = new System.Drawing.Point(158, 110);
            this.tbSalePrice.Name = "tbSalePrice";
            this.tbSalePrice.Properties.Appearance.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalePrice.Properties.Appearance.Options.UseFont = true;
            this.tbSalePrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.tbSalePrice.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.tbSalePrice.Properties.MaskSettings.Set("mask", "\\d+(\\R.\\d{0,2})?");
            this.tbSalePrice.Properties.MaskSettings.Set("allowBlankInput", false);
            this.tbSalePrice.Properties.MaskSettings.Set("placeholder", '\0');
            this.tbSalePrice.Properties.MaskSettings.Set("showPlaceholders", false);
            this.tbSalePrice.Properties.MaskSettings.Set("culture", "");
            this.tbSalePrice.Size = new System.Drawing.Size(179, 26);
            this.tbSalePrice.TabIndex = 3;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(467, 45);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Properties.Appearance.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Properties.Appearance.Options.UseFont = true;
            this.tbDescription.Size = new System.Drawing.Size(250, 26);
            this.tbDescription.TabIndex = 2;
            // 
            // tbBalance
            // 
            this.tbBalance.Location = new System.Drawing.Point(468, 109);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.Properties.Appearance.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBalance.Properties.Appearance.Options.UseFont = true;
            this.tbBalance.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.tbBalance.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.tbBalance.Properties.MaskSettings.Set("mask", "\\d+");
            this.tbBalance.Properties.MaskSettings.Set("placeholder", '\0');
            this.tbBalance.Properties.MaskSettings.Set("allowBlankInput", false);
            this.tbBalance.Properties.UseMaskAsDisplayFormat = true;
            this.tbBalance.Size = new System.Drawing.Size(250, 26);
            this.tbBalance.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(2)))), ((int)(((byte)(108)))));
            this.btnDelete.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(2)))), ((int)(((byte)(108)))));
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseBorderColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(414, 174);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 42);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Eliminar";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(2)))), ((int)(((byte)(108)))));
            this.btnSave.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(2)))), ((int)(((byte)(108)))));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseBorderColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(574, 174);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 42);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Agregar";
            // 
            // btnClear
            // 
            this.btnClear.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(2)))), ((int)(((byte)(108)))));
            this.btnClear.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(2)))), ((int)(((byte)(108)))));
            this.btnClear.Appearance.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnClear.Appearance.Options.UseBackColor = true;
            this.btnClear.Appearance.Options.UseBorderColor = true;
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.ImageOptions.Image")));
            this.btnClear.Location = new System.Drawing.Point(248, 174);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 42);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Limpiar";
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 559);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbBalance);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbSalePrice);
            this.Controls.Add(this.tbProductId);
            this.Controls.Add(this.gcProducts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductView";
            this.Text = "ProductView";
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSalePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBalance.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl gcProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit tbProductId;
        private DevExpress.XtraEditors.TextEdit tbSalePrice;
        private DevExpress.XtraEditors.TextEdit tbDescription;
        private DevExpress.XtraEditors.TextEdit tbBalance;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClear;
    }
}