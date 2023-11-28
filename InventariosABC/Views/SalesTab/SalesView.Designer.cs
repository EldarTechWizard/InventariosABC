namespace InventariosABC.Views.SalesTab
{
    partial class SalesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesView));
            this.tbProductId = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.tbTotal = new DevExpress.XtraEditors.TextEdit();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.tbSalePrice = new DevExpress.XtraEditors.TextEdit();
            this.tbQuantity = new DevExpress.XtraEditors.TextEdit();
            this.tbFolio = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.gcRecords = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lueDescription = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.lFolio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSalePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFolio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tbProductId
            // 
            this.tbProductId.Location = new System.Drawing.Point(137, 161);
            this.tbProductId.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbProductId.Name = "tbProductId";
            this.tbProductId.Properties.Appearance.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductId.Properties.Appearance.Options.UseFont = true;
            this.tbProductId.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.tbProductId.Properties.MaskSettings.Set("mask", "\\d+");
            this.tbProductId.Properties.MaskSettings.Set("placeholder", '\0');
            this.tbProductId.Properties.MaskSettings.Set("showPlaceholders", false);
            this.tbProductId.Properties.MaskSettings.Set("allowBlankInput", true);
            this.tbProductId.Size = new System.Drawing.Size(177, 26);
            this.tbProductId.TabIndex = 33;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(2)))), ((int)(((byte)(108)))));
            this.btnSave.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(2)))), ((int)(((byte)(108)))));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseBorderColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(621, 887);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(228, 62);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Guardar";
            // 
            // btnClear
            // 
            this.btnClear.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(2)))), ((int)(((byte)(108)))));
            this.btnClear.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(2)))), ((int)(((byte)(108)))));
            this.btnClear.Appearance.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnClear.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnClear.Appearance.Options.UseBackColor = true;
            this.btnClear.Appearance.Options.UseBorderColor = true;
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.ImageOptions.Image")));
            this.btnClear.Location = new System.Drawing.Point(73, 887);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(198, 62);
            this.btnClear.TabIndex = 42;
            this.btnClear.Text = "Limpiar";
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(2)))), ((int)(((byte)(108)))));
            this.btnDelete.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(2)))), ((int)(((byte)(108)))));
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseBorderColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(331, 887);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(215, 62);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Eliminar";
            // 
            // btnInsert
            // 
            this.btnInsert.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(2)))), ((int)(((byte)(108)))));
            this.btnInsert.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(2)))), ((int)(((byte)(108)))));
            this.btnInsert.Appearance.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnInsert.Appearance.Options.UseBackColor = true;
            this.btnInsert.Appearance.Options.UseBorderColor = true;
            this.btnInsert.Appearance.Options.UseFont = true;
            this.btnInsert.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.ImageOptions.Image")));
            this.btnInsert.Location = new System.Drawing.Point(621, 328);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(214, 62);
            this.btnInsert.TabIndex = 39;
            this.btnInsert.Text = "Insertar";
            // 
            // tbTotal
            // 
            this.tbTotal.EditValue = "0";
            this.tbTotal.Location = new System.Drawing.Point(660, 802);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Properties.Appearance.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Properties.Appearance.Options.UseFont = true;
            this.tbTotal.Properties.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(195, 26);
            this.tbTotal.TabIndex = 48;
            // 
            // dpDate
            // 
            this.dpDate.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDate.Location = new System.Drawing.Point(467, 58);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(364, 28);
            this.dpDate.TabIndex = 30;
            // 
            // tbSalePrice
            // 
            this.tbSalePrice.Location = new System.Drawing.Point(569, 251);
            this.tbSalePrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbSalePrice.Name = "tbSalePrice";
            this.tbSalePrice.Properties.Appearance.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalePrice.Properties.Appearance.Options.UseFont = true;
            this.tbSalePrice.Properties.HideSelection = false;
            this.tbSalePrice.Properties.ReadOnly = true;
            this.tbSalePrice.Size = new System.Drawing.Size(262, 26);
            this.tbSalePrice.TabIndex = 38;
            // 
            // tbQuantity
            // 
            this.tbQuantity.EditValue = "1";
            this.tbQuantity.Location = new System.Drawing.Point(137, 251);
            this.tbQuantity.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Properties.Appearance.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantity.Properties.Appearance.Options.UseFont = true;
            this.tbQuantity.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.tbQuantity.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.tbQuantity.Properties.MaskSettings.Set("mask", "\\d+");
            this.tbQuantity.Properties.MaskSettings.Set("showPlaceholders", false);
            this.tbQuantity.Properties.MaskSettings.Set("allowBlankInput", false);
            this.tbQuantity.Size = new System.Drawing.Size(177, 26);
            this.tbQuantity.TabIndex = 36;
            // 
            // tbFolio
            // 
            this.tbFolio.Location = new System.Drawing.Point(137, 52);
            this.tbFolio.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbFolio.Name = "tbFolio";
            this.tbFolio.Properties.Appearance.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFolio.Properties.Appearance.Options.UseFont = true;
            this.tbFolio.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.tbFolio.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.tbFolio.Properties.MaskSettings.Set("mask", "\\d+");
            this.tbFolio.Properties.MaskSettings.Set("isAutoComplete", false);
            this.tbFolio.Properties.MaskSettings.Set("showPlaceholders", false);
            this.tbFolio.Properties.MaskSettings.Set("allowBlankInput", true);
            this.tbFolio.Properties.UseMaskAsDisplayFormat = true;
            this.tbFolio.Size = new System.Drawing.Size(197, 26);
            this.tbFolio.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(500, 805);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Precio de venta:";
            // 
            // gcRecords
            // 
            this.gcRecords.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gcRecords.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcRecords.Location = new System.Drawing.Point(43, 450);
            this.gcRecords.MainView = this.gridView1;
            this.gcRecords.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gcRecords.Name = "gcRecords";
            this.gcRecords.Size = new System.Drawing.Size(812, 312);
            this.gcRecords.TabIndex = 46;
            this.gcRecords.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 546;
            this.gridView1.GridControl = this.gcRecords;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(407, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Precio de venta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Descripcion:";
            // 
            // lueDescription
            // 
            this.lueDescription.EditValue = "";
            this.lueDescription.Location = new System.Drawing.Point(411, 161);
            this.lueDescription.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lueDescription.Name = "lueDescription";
            this.lueDescription.Properties.Appearance.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueDescription.Properties.Appearance.Options.UseFont = true;
            this.lueDescription.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDescription.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueDescription.Size = new System.Drawing.Size(438, 26);
            this.lueDescription.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Producto:";
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDate.Location = new System.Drawing.Point(389, 58);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(59, 20);
            this.lDate.TabIndex = 31;
            this.lDate.Text = "Fecha:";
            // 
            // lFolio
            // 
            this.lFolio.AutoSize = true;
            this.lFolio.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFolio.Location = new System.Drawing.Point(69, 55);
            this.lFolio.Name = "lFolio";
            this.lFolio.Size = new System.Drawing.Size(51, 20);
            this.lFolio.TabIndex = 28;
            this.lFolio.Text = "Folio:";
            // 
            // SalesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 972);
            this.Controls.Add(this.tbProductId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.tbSalePrice);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbFolio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gcRecords);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lueDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.lFolio);
            this.Name = "SalesView";
            this.Text = "SalesView";
            ((System.ComponentModel.ISupportInitialize)(this.tbProductId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSalePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFolio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDescription.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tbProductId;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.TextEdit tbTotal;
        private System.Windows.Forms.DateTimePicker dpDate;
        private DevExpress.XtraEditors.TextEdit tbSalePrice;
        private DevExpress.XtraEditors.TextEdit tbQuantity;
        private DevExpress.XtraEditors.TextEdit tbFolio;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.GridControl gcRecords;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LookUpEdit lueDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label lFolio;
    }
}