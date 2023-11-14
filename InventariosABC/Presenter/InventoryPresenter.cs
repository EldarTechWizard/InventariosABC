using DevExpress.XtraGrid.Views.Grid;
using InventariosABC.Views.InventoryTab;
using InventariosABC.Views.MainTab;
using InventariosABC.Views.ProductPickerTab;
using SqlInventoryLibrary.Models;
using SqlInventoryLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventariosABC.Presenter
{
    public class InventoryPresenter
    {

        private IInventoryView view;
        private IInventorySqlRepository sqlRepository;
        private Dictionary<int,Record> records = new Dictionary<int,Record>();
        private List<DetailsRecord> detailsList = new List<DetailsRecord>();
        private Dictionary<int,Product> productList = new Dictionary<int,Product>();
        private int maxFolio = 0;
  

        public InventoryPresenter(IInventoryView view)
        {
            this.view = view;
            sqlRepository = new InventorySqlRepository();
            this.view.SaveEvent += this.SaveEvent;
            this.view.DeleteEvent += this.DeleteEvent;
            this.view.ClearEvent += this.ClearEvent;
            this.view.FolioChangedEvent += this.FolioChangedEvent;
            this.view.KeyDownEvent += this.KeyDownEvent;
            //this.view.KeyReleaseEvent += this.KeyPressEvent;
            this.view.LoadEvent += this.LoadEvent;
            this.view.DescriptionChanged += this.DescriptionChanged;
            this.view.InsertEvent += this.InsertEvent;
            this.view.RightClickRowEvent += this.RightClickRowEvent;
        }

        private void RightClickRowEvent(object sender, RowCellClickEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                DialogResult dialogResult = MessageBox.Show("Deshacer registro?", "Deshacer Registro", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int index = 0;
                    view.DeleteRowIndex(ref index);

                    int i = 0;
                    foreach(DetailsRecord details in detailsList)
                    {
                        if(details.Product.ProductID == index)
                        {
                            break;
                        }
                        i++;
                    }

                    detailsList.RemoveAt(i);
                }
            }
        }

        public void LoadEvent(object sender, EventArgs e)
        {
            
            GetProducts();
            GetRecords();
            SetMaxFolio();

            DataTable data = new DataTable();
            data.Columns.Add("productId", typeof(String));
            data.Columns.Add("description", typeof(String));
            data.Columns.Add("quantity", typeof(double));
            data.Columns.Add("salePrice", typeof(double));
            data.Columns.Add("amount", typeof(double));
            view.SetDataSourceDataGrid(data);
        }

        public void SaveEvent(object sender, EventArgs e)
        {
            SaveFolio();
        }

        public void DeleteEvent(object sender, EventArgs e)
        {
            DeleteFolio();
        }
        public void ClearEvent(object sender, EventArgs e)
        {
            CleanFolio();
        }
        public void FolioChangedEvent(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        public void DescriptionChanged(object sender, EventArgs e)
        {
            AutoFillTextBox();
        }

        public void InsertEvent(object sender, EventArgs e)
        {
            try
            {

                List<string> list = new List<string>() { "Entrada","Salida"};
                if (!list.Contains(view.MovementType))
                {
                    throw new Exception("Error el tipo de movimiento solo puede ser entrada o salida");
                }

                if (view.Quantity == 0)
                {
                    throw new Exception("Error la cantidad de producto debe ser mayor a 0");
                }

                Product product = new Product();
                product.ProductID = view.ProductId;
                product.SalePrice = view.SalesPrice;
                product.Description = view.Description;
                product.Balance = view.Balance;

                if (view.MovementType == "Salida")
                {
                    double newQuantity = productList[product.ProductID].Balance - view.Quantity;

                    if(newQuantity < 0)
                    {
                        throw new Exception("La cantidad no puede ser mayor al numero de articulos restantes del producto");
                    }
                    else
                    {
                        productList[product.ProductID].Balance = newQuantity;
                    }
                }

                bool isProductAlready = false;
                foreach (DetailsRecord details in detailsList)
                {
                    if (details.Product.ProductID == view.ProductId)
                    {
                        view.UpdateProductQuantity();
                        details.Quantity += view.Quantity;
                        details.Amount += (view.SalesPrice * view.Quantity);

                        isProductAlready = true;
                    }
                }

                DetailsRecord detailsRecord = new DetailsRecord
                {
                    Product = product,

                    Quantity = view.Quantity,

                    Amount = view.Quantity * product.SalePrice
                };

                view.TotalAmount += view.Quantity * product.SalePrice;

                if (detailsList.Count == 0)
                {
                    view.SwicthStateMovementType(false);
                }



                if (!isProductAlready)
                {
                    detailsList.Add(detailsRecord);
                    AddNewRowDG();
                }
                
                //view.ClearProducTextBox();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }

        public void KeyDownEvent(object sender, KeyEventArgs e)
        {
                    

            if (e.KeyCode == Keys.F1)
            {
                IProductPickerView IviewPP = new ProductPickerView();
                ProductPickerPresenter pickerPresenter = new ProductPickerPresenter(IviewPP);

                Form productPicker = (Form)IviewPP;
                productPicker.ShowDialog();


                Product product = pickerPresenter.GetResources();
                if (product != null)
                {
                    view.ProductId = product.ProductID;
                    view.Description = product.Description;
                    view.SalesPrice = product.SalePrice;
                    view.Balance = product.Balance;
                }
            }

                       
        }

        public void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
        }


        public void GetRecords()
        {
            try
            {
                DataTable data = new DataTable();
                if (!sqlRepository.GetAllRegisters(ref data))
                {
                    throw new Exception(sqlRepository.LastError);
                }


                records.Clear();
                foreach (DataRow row in data.Rows)
                {
                    Record record = new Record();

                    record.Folio = (int)row["folio"];
                    record.Date = row["entryDate"].ToString();
                    record.Total = double.Parse(row["total"].ToString());
                    record.MovementType = row["movementType"].ToString();

                    records.Add(record.Folio, record);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }           
        }

        public void GetProducts()
        {
            try
            {
                DataTable dataTable = new DataTable();

                if(!sqlRepository.GetAllProducts(ref dataTable))
                {
                    throw new Exception(sqlRepository.LastError);
                }

                productList.Clear();

                foreach (DataRow row in dataTable.Rows)
                {
                    Product product = new Product();

                    product.ProductID = (int)row["productId"];
                    product.Description = row["description"].ToString();
                    product.SalePrice = double.Parse(row["salePrice"].ToString());
                    product.Balance = double.Parse(row["balance"].ToString());

                    productList.Add(product.ProductID, product);
                }

                view.SetDataSourceLookUpEdit(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void AddNewRowDG()
        {
            try
            {
                view.AddNewRowDataGrid();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateDataGrid()
        {
            try
            {
                DataTable dataTransactions = new DataTable();
                DataTable dataHeader = new DataTable();

                if (!records.ContainsKey(view.Folio))
                {

                    view.SetDataSourceDataGrid(null);
                    view.SwicthStateMovementType(true);
                    view.ChangeToReadOnlyMode(false);

                    detailsList.Clear();

                    view.TotalAmount = 0;

                    return;
                }


                if(!sqlRepository.GetAllTransactionData(ref dataTransactions, view.Folio))
                {
                    throw new Exception(sqlRepository.LastError);
                }

                if (!sqlRepository.GetRegister(ref dataHeader, view.Folio))
                {
                    throw new Exception(sqlRepository.LastError);
                }

                

                foreach(DataRow row in dataTransactions.Rows)
                {
                    DetailsRecord detailsRecord = new DetailsRecord();
                    Product product = new Product
                    {
                        ProductID = (int)row["productId"],
                        Description = row["description"].ToString(),
                        SalePrice = double.Parse(row["salePrice"].ToString())
                    };

                    product.Balance = double.Parse(productList[product.ProductID].Balance.ToString());

                    detailsRecord.Quantity = int.Parse(row["quantity"].ToString()); 
                    detailsRecord.Amount = double.Parse(row["amount"].ToString());
                    detailsRecord.Product = product;

                    detailsList.Add(detailsRecord);
                }


                string date = dataHeader.Rows[0]["entryDate"].ToString();

                view.Date = date.Substring(0, 10);
                view.MovementType = dataHeader.Rows[0]["movementType"].ToString();
                view.TotalAmount = double.Parse(dataHeader.Rows[0]["total"].ToString());

                view.SetDataSourceDataGrid(dataTransactions);
                view.SwicthStateMovementType(false);
                view.ClearProducTextBox();
                view.ChangeToReadOnlyMode(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void SaveFolio()
        {
            try
            {
                Record record = new Record();

                record.Folio = view.Folio;
                record.Date = view.Date;
                record.MovementType = view.MovementType;
                record.Total = view.TotalAmount;
                record.DetailsRecords = detailsList;

                if(view.Folio == 0)
                {
                    throw new Exception("El folio debe ser un numero entero mayor a 0");
                }

                if(detailsList.Count == 0) 
                {
                    throw new Exception("No puede haber transacciones vacias");
                }

                if (!sqlRepository.InsertNewsRegisters(record))
                {
                    throw new Exception(sqlRepository.LastError);
                }


                view.ClearAllTextBox();

                GetRecords();
                GetProducts();
                SetMaxFolio();

                

                MessageBox.Show("Registros insertados correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void DeleteFolio()
        {
            try
            {
                Record record = new Record
                {
                    Folio = view.Folio,
                    Date = view.Date,
                    MovementType = view.MovementType,
                    Total = view.TotalAmount,
                    DetailsRecords = detailsList
                };

                if(view.Folio == 0)
                {
                    throw new Exception("Debe llenar el folio con un numero valido");
                }

                DialogResult dialogResult = MessageBox.Show("Desea eliminar este registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                if (!sqlRepository.DeleteRegisters(record))
                {
                    throw new Exception(sqlRepository.LastError);
                }

                view.ClearAllTextBox();
                GetRecords();
                GetProducts();
                detailsList.Clear();
                view.SetDataSourceDataGrid(null);

                MessageBox.Show("Folio eliminado correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void AutoFillTextBox()
        {
            try
            {
                Product product = productList[int.Parse(view.EditValue)];
                view.ProductId = product.ProductID;
                view.SalesPrice = product.SalePrice;
                view.Balance = product.Balance;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void CleanFolio()
        {
            view.ClearAllTextBox();
            view.SwicthStateMovementType(true);
        }

        public void SetMaxFolio()
        {
            try
            {
                if(!sqlRepository.GetMaxFolio(ref maxFolio))
                {
                    throw new Exception(sqlRepository.LastError);
                }

                maxFolio++;

                view.Folio = maxFolio;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
