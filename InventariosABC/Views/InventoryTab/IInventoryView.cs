﻿using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventariosABC.Views.InventoryTab
{
    public interface IInventoryView
    {
        int Folio {  get; set; }
        string Date { get; set; }
        string MovementType { get; set; }
        int ProductId { get; set; }
        string Description { get; set; }            
        double SalesPrice { get; set; }
        double Balance { get; set; }
        int Quantity { get; set; }
        string EditValue { get; set; }
        double TotalAmount { get; set; }

        bool FolioExist { get; set; }

        event EventHandler LoadEvent;
        event EventHandler SaveEvent;
        event EventHandler DeleteEvent;
        event EventHandler ClearEvent;
        event EventHandler FolioChangedEvent;
        event KeyEventHandler KeyDownEvent;
        event KeyPressEventHandler KeyPressEvent;
        event EventHandler InsertEvent;
        event EventHandler DescriptionChanged;
        event RowCellClickEventHandler RightClickRowEvent;
        event EventHandler ProductIdChanged;
        void SetDataSourceDataGrid(DataTable data);
        void SetDataSourceLookUpEdit(DataTable data);
        void AddNewRowDataGrid();
        void UpdateProductQuantity();
        void ClearAllTextBox();
        void ClearProducTextBox();
        void ClearIdTextBox();
        void SwicthStateMovementType(bool val);
        void DeleteRowIndex(ref int index);
        void ChangeToReadOnlyMode(bool aux);
        void ClearProducTextBoxIdHead();


    }
}
