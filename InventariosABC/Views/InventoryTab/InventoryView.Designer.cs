namespace InventariosABC.Views.InventoryTab
{
    partial class InventoryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryView));
            this.lFolio = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lueDescription = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gcRecords = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMovementType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tbFolio = new DevExpress.XtraEditors.TextEdit();
            this.tbQuantity = new DevExpress.XtraEditors.TextEdit();
            this.tbSalePrice = new DevExpress.XtraEditors.TextEdit();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.tbTotal = new DevExpress.XtraEditors.TextEdit();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.tbProductId = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMovementType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFolio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSalePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lFolio
            // 
            this.lFolio.AutoSize = true;
            this.lFolio.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFolio.Location = new System.Drawing.Point(118, 42);
            this.lFolio.Name = "lFolio";
            this.lFolio.Size = new System.Drawing.Size(51, 20);
            this.lFolio.TabIndex = 1;
            this.lFolio.Text = "Folio:";
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDate.Location = new System.Drawing.Point(420, 42);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(59, 20);
            this.lDate.TabIndex = 3;
            this.lDate.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo de movimiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Producto:";
            // 
            // lueDescription
            // 
            this.lueDescription.EditValue = "";
            this.lueDescription.Location = new System.Drawing.Point(399, 163);
            this.lueDescription.Name = "lueDescription";
            this.lueDescription.Properties.Appearance.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueDescription.Properties.Appearance.Options.UseFont = true;
            this.lueDescription.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDescription.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueDescription.Size = new System.Drawing.Size(315, 26);
            this.lueDescription.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(396, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(396, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Precio de venta:";
            // 
            // gcRecords
            // 
            this.gcRecords.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcRecords.Location = new System.Drawing.Point(60, 351);
            this.gcRecords.MainView = this.gridView1;
            this.gcRecords.Name = "gcRecords";
            this.gcRecords.Size = new System.Drawing.Size(654, 200);
            this.gcRecords.TabIndex = 14;
            this.gcRecords.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcRecords;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(441, 570);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Precio de venta:";
            // 
            // cbMovementType
            // 
            this.cbMovementType.Location = new System.Drawing.Point(198, 90);
            this.cbMovementType.Name = "cbMovementType";
            this.cbMovementType.Properties.Appearance.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMovementType.Properties.Appearance.Options.UseFont = true;
            this.cbMovementType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMovementType.Properties.Items.AddRange(new object[] {
            "Entrada",
            "Salida"});
            this.cbMovementType.Size = new System.Drawing.Size(176, 26);
            this.cbMovementType.TabIndex = 3;
            // 
            // tbFolio
            // 
            this.tbFolio.Location = new System.Drawing.Point(198, 36);
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
            this.tbFolio.Size = new System.Drawing.Size(176, 26);
            this.tbFolio.TabIndex = 1;
            this.tbFolio.InvalidValue += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.tbFolio_InvalidValue);
            // 
            // tbQuantity
            // 
            this.tbQuantity.EditValue = "1";
            this.tbQuantity.Location = new System.Drawing.Point(200, 230);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Properties.Appearance.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantity.Properties.Appearance.Options.UseFont = true;
            this.tbQuantity.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.tbQuantity.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.tbQuantity.Properties.MaskSettings.Set("mask", "\\d+");
            this.tbQuantity.Properties.MaskSettings.Set("showPlaceholders", false);
            this.tbQuantity.Properties.MaskSettings.Set("allowBlankInput", false);
            this.tbQuantity.Size = new System.Drawing.Size(174, 26);
            this.tbQuantity.TabIndex = 6;
            // 
            // tbSalePrice
            // 
            this.tbSalePrice.Location = new System.Drawing.Point(546, 233);
            this.tbSalePrice.Name = "tbSalePrice";
            this.tbSalePrice.Properties.Appearance.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalePrice.Properties.Appearance.Options.UseFont = true;
            this.tbSalePrice.Properties.HideSelection = false;
            this.tbSalePrice.Properties.ReadOnly = true;
            this.tbSalePrice.Size = new System.Drawing.Size(168, 26);
            this.tbSalePrice.TabIndex = 7;
            // 
            // dpDate
            // 
            this.dpDate.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDate.Location = new System.Drawing.Point(506, 36);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(208, 28);
            this.dpDate.TabIndex = 2;
            // 
            // tbTotal
            // 
            this.tbTotal.EditValue = "0";
            this.tbTotal.Location = new System.Drawing.Point(589, 567);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Properties.Appearance.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Properties.Appearance.Options.UseFont = true;
            this.tbTotal.Properties.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(125, 26);
            this.tbTotal.TabIndex = 27;
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
            this.btnInsert.Location = new System.Drawing.Point(577, 292);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(137, 40);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insertar";
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
            this.btnDelete.Location = new System.Drawing.Point(400, 630);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 40);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Eliminar";
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
            this.btnClear.Location = new System.Drawing.Point(237, 630);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 40);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Limpiar";
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
            this.btnSave.Location = new System.Drawing.Point(568, 630);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 40);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Guardar";
            // 
            // tbProductId
            // 
            this.tbProductId.Location = new System.Drawing.Point(198, 163);
            this.tbProductId.Name = "tbProductId";
            this.tbProductId.Properties.Appearance.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductId.Properties.Appearance.Options.UseFont = true;
            this.tbProductId.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.tbProductId.Properties.MaskSettings.Set("mask", "\\d+");
            this.tbProductId.Properties.MaskSettings.Set("placeholder", '\0');
            this.tbProductId.Properties.MaskSettings.Set("showPlaceholders", false);
            this.tbProductId.Properties.MaskSettings.Set("allowBlankInput", true);
            this.tbProductId.Size = new System.Drawing.Size(176, 26);
            this.tbProductId.TabIndex = 4;
            // 
            // InventoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 741);
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
            this.Controls.Add(this.cbMovementType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gcRecords);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lueDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.lFolio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryView";
            this.Text = "InventoryView";
            ((System.ComponentModel.ISupportInitialize)(this.lueDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMovementType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFolio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSalePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductId.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lFolio;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit lueDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.GridControl gcRecords;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.ComboBoxEdit cbMovementType;
        private DevExpress.XtraEditors.TextEdit tbFolio;
        private DevExpress.XtraEditors.TextEdit tbQuantity;
        private DevExpress.XtraEditors.TextEdit tbSalePrice;
        private System.Windows.Forms.DateTimePicker dpDate;
        private DevExpress.XtraEditors.TextEdit tbTotal;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit tbProductId;
    }
}