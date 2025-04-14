using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pbl.entity_class;
using pbl.Manager.Interface;


namespace pbl.Manager.BLL
{
    internal class InventoryHistoryManagement : IInventoryHistory
    {
        private readonly List<InventoryTransaction> IT = new();
        public async Task AddTransaction(InventoryTransaction transaction)
        {
            IT.Add(transaction);
            Console.WriteLine("Thêm lịch sử");
            return ;
        } 
        public async Task<List<InventoryTransaction>> GetHistoryByProductId(int productID)
        {
            return await Task.FromResult(IT.Where(p => p.ProductId == productID).ToList());
        }
        public async Task Display()
        {
            if (!IT.Any())
            {
                Console.WriteLine("Danh sách rỗng");
                return ;
            }
            Console.WriteLine("Lich su: ");

            foreach (InventoryTransaction h in IT)
            {
                Console.WriteLine($"- [{h.ChangedTime}] SP: {h.ProductId}, Hành động: {h.ActionType}," +
                    $" Số lượng: {h.QuantityChanged}, Ghi chú: {h.note}");
                
            }
            return;
        }
        public async Task DeleteHistoryByTransactionId(int tranId)
        {
            var history = IT.FirstOrDefault(p => p.TransactionId == tranId);
            if (history == null)
            {
                Console.WriteLine("Lịch sử này không tồn tại");
                return ;
            }
            IT.Remove(history);
            Console.WriteLine("Xóa thành công!");
            return;
        }
        public async Task DeleteHistoryByProductId(int id)
        {
            var history = IT.FirstOrDefault(p => p.ProductId == id);
            if (history == null)
            {
                Console.WriteLine("khong thay lịch sử sản phẩm này!");
                return ;
            }
            IT.Remove(history);
            Console.WriteLine("đã xóa ls nha!");
            return;
        }
    }
}
