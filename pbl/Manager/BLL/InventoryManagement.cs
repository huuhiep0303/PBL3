using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inforProduct;
using pbl.entity_class;
using pbl.Manager.Interface;

namespace pbl.Manager.BLL
{
    internal class InventoryManagement : IInventoryManagement
    {
        private readonly List<Inventory> inventories = new();
        private readonly IInventoryHistory historyService;
        public InventoryManagement(IInventoryHistory historyService)
        {
            this.historyService = historyService;
        }
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
        public async Task<bool> ImportOrReturnStock(int productId, int amount,string actionType)// cập nhật hàng khi thêm và có bị trả hàng
        {
            
            var inv = inventories.FirstOrDefault(i => i.productId == productId);

            if (inv == null)
            {
                Console.WriteLine("Sản phẩm không tồn tại");
                return await Task.FromResult(false);
            }
            
            inv.Quantity += amount;
            inv.lastUpdate = DateTime.Now;
            if (string.Equals("IMPORT", actionType, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Nhập thêm {amount} sản phẩm {productId}. Tồn kho hiện tại: {inv.Quantity}");
                await historyService.AddTransaction(new InventoryTransaction(productId, "IMPORT", amount, "Nhập thêm hàng!"));
            } else if (string.Equals("RETURN", actionType, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Trả {amount} sản phẩm {productId}. Tồn kho hiện tại: {inv.Quantity}");
                await historyService.AddTransaction(new InventoryTransaction(productId, "RETURN", amount, "Trả hàng!"));
            }else return await Task.FromResult(false);

            return await Task.FromResult(true);
        }
        public async Task<bool> ReduceOrSaleStock(int productId, int amount, string actionType)// xuất và bán hàng kèm tạo lịch sử
        {
            var inv = inventories.FirstOrDefault(i => i.productId == productId);
            if (inv == null)
            {
                Console.WriteLine("Không tồn tại sản phẩm này");
                return await Task.FromResult(false);
            }
            else if (inv.Quantity < amount)
            {
                Console.WriteLine("Không đủ hàng!");
                return await Task.FromResult(false);
            }
            inv.Quantity -= amount;
            inv.lastUpdate = DateTime.Now;

            if (string.Equals("REDUCE", actionType, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Đã xuất khỏi kho {amount} sản phẩm {productId}. Còn lại: {inv.Quantity}");
                await historyService.AddTransaction(new InventoryTransaction(productId, "REDUCE", amount, "Xuất hàng!"));
            }
            else if (string.Equals("SALE", actionType, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Đã bán {amount} sản phẩm {productId}. Còn lại: {inv.Quantity}");
                await historyService.AddTransaction(new InventoryTransaction(productId, "SALE", amount, "Bán hàng!"));
            }
            else return await Task.FromResult(false);
                
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
        public async Task<bool> RestoreStock(int productID, int amount)
        {
            var inv = inventories.FirstOrDefault(i => i.productId == productID);
            if (inv == null)
            {
                Console.WriteLine("Sai sp");
                return false;
            }
            inv.Quantity += amount;
            inv.lastUpdate = DateTime.Now;
            Console.WriteLine($" Phục hồi {amount} sản phẩm {productID}. Tồn kho mới: {inv.Quantity}");
            await historyService.AddTransaction(new InventoryTransaction(productID, "RESTORE"
                , amount, "Khôi phục hàng do bị hủy hàng!"));
            return true;
        }

    }
}
