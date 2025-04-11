using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inforProduct;

namespace pbl.Manager.Interface
{
    internal interface IInventoryManagement
    {
        Task<bool> CreateRecord(int productId, int initialQuantity, int reorderQuantity);
        Task<bool> ImportStock(int productId, int amount);
        Task<bool> ReduceStock(int productId, int amount);
        Task<Inventory> GetInventoryById(int inventoryId);
        Task DisplayLowStockProductsAsync();
    }
}
