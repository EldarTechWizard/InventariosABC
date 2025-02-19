﻿namespace InventariosABC.Views.ProductPickerTab
{
    partial class ProductPickerView
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcProducts = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnChoose = new DevExpress.XtraEditors.SimpleButton();
            this.lueDescription = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcProducts
            // 
            this.gcProducts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcProducts.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcProducts.Location = new System.Drawing.Point(0, 128);
            this.gcProducts.MainView = this.gridView1;
            this.gcProducts.Name = "gcProducts";
            this.gcProducts.Size = new System.Drawing.Size(501, 513);
            this.gcProducts.TabIndex = 0;
            this.gcProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcProducts;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // btnChoose
            // 
            this.btnChoose.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(2)))), ((int)(((byte)(108)))));
            this.btnChoose.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(2)))), ((int)(((byte)(108)))));
            this.btnChoose.Appearance.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnChoose.Appearance.Options.UseBackColor = true;
            this.btnChoose.Appearance.Options.UseBorderColor = true;
            this.btnChoose.Appearance.Options.UseFont = true;
            this.btnChoose.Location = new System.Drawing.Point(359, 26);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(116, 35);
            this.btnChoose.TabIndex = 24;
            this.btnChoose.Text = "Elegir";
            // 
            // lueDescription
            // 
            this.lueDescription.EditValue = "";
            this.lueDescription.Location = new System.Drawing.Point(12, 31);
            this.lueDescription.Name = "lueDescription";
            this.lueDescription.Properties.Appearance.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueDescription.Properties.Appearance.Options.UseFont = true;
            this.lueDescription.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, false, false, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.lueDescription.Properties.DropDownRows = 1;
            this.lueDescription.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            this.lueDescription.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.lueDescription.Properties.ShowHeader = false;
            this.lueDescription.Size = new System.Drawing.Size(315, 26);
            this.lueDescription.TabIndex = 25;
            // 
            // ProductPickerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 641);
            this.Controls.Add(this.lueDescription);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.gcProducts);
            this.Name = "ProductPickerView";
            this.Text = "ProductPickerView";
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDescription.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnChoose;
        private DevExpress.XtraEditors.LookUpEdit lueDescription;
    }
}