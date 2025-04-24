using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pbl.entity_class;

namespace pbl.Manager.Interface
{
    internal interface IInventoryHistory
    {
        Task AddTransaction(InventoryTransaction transaction);
        Task<List<InventoryTransaction>> GetHistoryByProductId(int productID);
        Task Display();
        Task DeleteHistoryByTransactionId(int tranId);
        Task DeleteHistoryByProductId(int productID);
        

    }
}
