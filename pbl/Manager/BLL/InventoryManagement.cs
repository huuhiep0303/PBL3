using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inforProduct;
using pbl.Manager.Interface;

namespace pbl.Manager.BLL
{
    internal class InventoryManagement : IInventoryManagement
    {
        private readonly List<Inventory> inventories = new();

        public async Task<bool> CreateRecord(int productId, int initialQuantity, int reorderQuantity)
        {
            if (inventories.Any(i => i.productId == productId))
            {
                Console.WriteLine("Kho của sản phẩm này đã tồn tại");
                return await Task.FromResult(false);
            }
            inventories.Add(new Inventory(productId, initialQuantity, reorderQuantity));
            Console.WriteLine($"✅ Tạo kho cho sản phẩm {productId} với SL: {initialQuantity}");
            return await Task.FromResult(true);
        }
        public async Task<bool> ImportStock(int productId, int amount)
        {
            var inv = inventories.FirstOrDefault(i => i.productId == productId);
            if (inv == null)
            {
                return await Task.FromResult(false);
            }
            inv.Quantity += amount;
            inv.lastUpdate = DateTime.Now;
            Console.WriteLine($"Nhập thêm {amount} sản phẩm {productId}. Tồn kho hiện tại: {inv.Quantity}");
            return await Task.FromResult(true);
        }
        public async Task<bool> ReduceStock(int productId, int amount)
        {
            var inv = inventories.FirstOrDefault(i => i.productId == productId);
            if (inv == null) return await Task.FromResult(false);
            inv.Quantity -= amount;
            inv.lastUpdate = DateTime.Now;
            Console.WriteLine($"Đã bán {amount} sản phẩm {productId}. Còn lại: {inv.Quantity}");
            return await Task.FromResult(true);
        }
        public async Task<Inventory> GetInventoryById(int inventoryId)
        {
            return await Task.FromResult(inventories.FirstOrDefault(i => i.inventoryId == inventoryId));
        }
        public async Task DisplayLowStockProductsAsync()
        {
            var lowStock = inventories.Where(i => i.NeedRestock()).ToList();
            if (!lowStock.Any())
            {
                Console.WriteLine("✅ Tất cả sản phẩm đều đủ hàng.");
                return ;
            }

            Console.WriteLine("⚠️ Các sản phẩm sắp hết hàng:");
            foreach (var inv in lowStock)
            {
                Console.WriteLine($" - ProductId: {inv.productId}, SL: {inv.Quantity}, Ngưỡng cảnh báo: {inv.ReorderLevel}");
            }

            return;
        }
    }
}
