using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlInventoryLibrary.Models
{
    public interface IInventorySqlRepository
    {
        string LastError { get;  }

        bool InsertNewsRegisters(Record record);
        bool DeleteRegisters(Record record);
        bool GetAllRegisters(ref DataTable data);
        bool GetRegister(ref DataTable data,int folio);
        bool GetAllTransactionData(ref DataTable data, int folio);
        bool GetAllProducts(ref DataTable data);
        bool InsertProducts(Product product);
        bool DeleteProduct(int productID);
        bool UpdateProducts(Product product);
        bool GetOneProduct(ref Product product);
        bool GetMaxFolio(ref int maxFolio);
        bool GetMaxProductId(ref int maxProductId);

    }
}
