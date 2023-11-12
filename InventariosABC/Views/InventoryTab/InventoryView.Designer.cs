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
            this.tbFolio = new CustomControls.RJControls.RJTextBox();
            this.lFolio = new System.Windows.Forms.Label();
            this.dpDate = new CustomControls.RJControls.RJDatePicker();
            this.lDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProductId = new CustomControls.RJControls.RJTextBox();
            this.lueDescription = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.tbQuantity = new CustomControls.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSalePrice = new CustomControls.RJControls.RJTextBox();
            this.gcRecords = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnSave = new CustomControls.RJControls.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTotal = new CustomControls.RJControls.RJTextBox();
            this.btnClear = new CustomControls.RJControls.RJButton();
            this.btnDelete = new CustomControls.RJControls.RJButton();
            this.cbMovementType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnInsert = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.lueDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMovementType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFolio
            // 
            this.tbFolio.BackColor = System.Drawing.SystemColors.Window;
            this.tbFolio.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbFolio.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbFolio.BorderRadius = 0;
            this.tbFolio.BorderSize = 2;
            this.tbFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFolio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbFolio.Location = new System.Drawing.Point(155, 70);
            this.tbFolio.Margin = new System.Windows.Forms.Padding(4);
            this.tbFolio.Multiline = false;
            this.tbFolio.Name = "tbFolio";
            this.tbFolio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbFolio.PasswordChar = false;
            this.tbFolio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbFolio.PlaceholderText = "";
            this.tbFolio.Size = new System.Drawing.Size(176, 35);
            this.tbFolio.TabIndex = 0;
            this.tbFolio.Texts = "";
            this.tbFolio.UnderlinedStyle = false;
            // 
            // lFolio
            // 
            this.lFolio.AutoSize = true;
            this.lFolio.Location = new System.Drawing.Point(100, 82);
            this.lFolio.Name = "lFolio";
            this.lFolio.Size = new System.Drawing.Size(40, 16);
            this.lFolio.TabIndex = 1;
            this.lFolio.Text = "Folio:";
            // 
            // dpDate
            // 
            this.dpDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dpDate.BorderSize = 0;
            this.dpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dpDate.Location = new System.Drawing.Point(456, 70);
            this.dpDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(319, 35);
            this.dpDate.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dpDate.TabIndex = 2;
            this.dpDate.TextColor = System.Drawing.Color.White;
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(402, 82);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(48, 16);
            this.lDate.TabIndex = 3;
            this.lDate.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo de movimiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Producto:";
            // 
            // tbProductId
            // 
            this.tbProductId.BackColor = System.Drawing.SystemColors.Window;
            this.tbProductId.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbProductId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbProductId.BorderRadius = 0;
            this.tbProductId.BorderSize = 2;
            this.tbProductId.Enabled = false;
            this.tbProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbProductId.Location = new System.Drawing.Point(157, 186);
            this.tbProductId.Margin = new System.Windows.Forms.Padding(4);
            this.tbProductId.Multiline = false;
            this.tbProductId.Name = "tbProductId";
            this.tbProductId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbProductId.PasswordChar = false;
            this.tbProductId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbProductId.PlaceholderText = "";
            this.tbProductId.Size = new System.Drawing.Size(176, 35);
            this.tbProductId.TabIndex = 7;
            this.tbProductId.Texts = "";
            this.tbProductId.UnderlinedStyle = false;
            // 
            // lueDescription
            // 
            this.lueDescription.EditValue = "";
            this.lueDescription.Location = new System.Drawing.Point(402, 192);
            this.lueDescription.Name = "lueDescription";
            this.lueDescription.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDescription.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueDescription.Size = new System.Drawing.Size(315, 22);
            this.lueDescription.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descripcion:";
            // 
            // tbQuantity
            // 
            this.tbQuantity.BackColor = System.Drawing.SystemColors.Window;
            this.tbQuantity.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbQuantity.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbQuantity.BorderRadius = 0;
            this.tbQuantity.BorderSize = 2;
            this.tbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbQuantity.Location = new System.Drawing.Point(157, 255);
            this.tbQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.tbQuantity.Multiline = false;
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbQuantity.PasswordChar = false;
            this.tbQuantity.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbQuantity.PlaceholderText = "";
            this.tbQuantity.Size = new System.Drawing.Size(176, 35);
            this.tbQuantity.TabIndex = 10;
            this.tbQuantity.Texts = "";
            this.tbQuantity.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Precio de venta:";
            // 
            // tbSalePrice
            // 
            this.tbSalePrice.BackColor = System.Drawing.SystemColors.Window;
            this.tbSalePrice.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbSalePrice.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbSalePrice.BorderRadius = 0;
            this.tbSalePrice.BorderSize = 2;
            this.tbSalePrice.Enabled = false;
            this.tbSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSalePrice.Location = new System.Drawing.Point(498, 255);
            this.tbSalePrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbSalePrice.Multiline = false;
            this.tbSalePrice.Name = "tbSalePrice";
            this.tbSalePrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbSalePrice.PasswordChar = false;
            this.tbSalePrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbSalePrice.PlaceholderText = "";
            this.tbSalePrice.Size = new System.Drawing.Size(219, 35);
            this.tbSalePrice.TabIndex = 12;
            this.tbSalePrice.Texts = "";
            this.tbSalePrice.UnderlinedStyle = false;
            // 
            // gcRecords
            // 
            this.gcRecords.Location = new System.Drawing.Point(63, 381);
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
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 0;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(567, 670);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Guardar";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 610);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Precio de venta:";
            // 
            // tbTotal
            // 
            this.tbTotal.BackColor = System.Drawing.SystemColors.Window;
            this.tbTotal.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbTotal.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbTotal.BorderRadius = 0;
            this.tbTotal.BorderSize = 2;
            this.tbTotal.Enabled = false;
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbTotal.Location = new System.Drawing.Point(602, 601);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(4);
            this.tbTotal.Multiline = false;
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbTotal.PasswordChar = false;
            this.tbTotal.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbTotal.PlaceholderText = "";
            this.tbTotal.Size = new System.Drawing.Size(115, 35);
            this.tbTotal.TabIndex = 16;
            this.tbTotal.Texts = "0";
            this.tbTotal.UnderlinedStyle = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClear.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClear.BorderRadius = 0;
            this.btnClear.BorderSize = 0;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(398, 670);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 40);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Limpiar";
            this.btnClear.TextColor = System.Drawing.Color.White;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDelete.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(225, 670);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 40);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // cbMovementType
            // 
            this.cbMovementType.Location = new System.Drawing.Point(155, 130);
            this.cbMovementType.Name = "cbMovementType";
            this.cbMovementType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMovementType.Properties.Items.AddRange(new object[] {
            "Entrada",
            "Salida"});
            this.cbMovementType.Size = new System.Drawing.Size(176, 22);
            this.cbMovementType.TabIndex = 20;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnInsert.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnInsert.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInsert.BorderRadius = 0;
            this.btnInsert.BorderSize = 0;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(567, 319);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(150, 40);
            this.btnInsert.TabIndex = 21;
            this.btnInsert.Text = "Insertar";
            this.btnInsert.TextColor = System.Drawing.Color.White;
            this.btnInsert.UseVisualStyleBackColor = false;
            // 
            // InventoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 746);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.cbMovementType);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gcRecords);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSalePrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lueDescription);
            this.Controls.Add(this.tbProductId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.lFolio);
            this.Controls.Add(this.tbFolio);
            this.Name = "InventoryView";
            this.Text = "InventoryView";
            ((System.ComponentModel.ISupportInitialize)(this.lueDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMovementType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJTextBox tbFolio;
        private System.Windows.Forms.Label lFolio;
        private CustomControls.RJControls.RJDatePicker dpDate;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox tbProductId;
        private DevExpress.XtraEditors.LookUpEdit lueDescription;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox tbQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJControls.RJTextBox tbSalePrice;
        private DevExpress.XtraGrid.GridControl gcRecords;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private CustomControls.RJControls.RJButton btnSave;
        private System.Windows.Forms.Label label6;
        private CustomControls.RJControls.RJTextBox tbTotal;
        private CustomControls.RJControls.RJButton btnClear;
        private CustomControls.RJControls.RJButton btnDelete;
        private DevExpress.XtraEditors.ComboBoxEdit cbMovementType;
        private CustomControls.RJControls.RJButton btnInsert;
    }
}