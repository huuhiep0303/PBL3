using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pbl.Manager.Interface;

namespace pbl.entity_class
{
    internal class ShoppingCart// quản lý danh sách sản phẩm đã chọn
    {
        
        public List<ShoppingCartItem> items { get; private set; } = new();

        public void AddItem(ShoppingCartItem item)
        {
            var existing = items.FirstOrDefault(p => p.productId == item.productId);
            if (existing != null)
            {
                existing.quantity += item.quantity;
                Console.WriteLine($"Sản phẩm đã tồn tại. Đã cập nhật số lượng mới : {existing.quantity} ");
            }
            else
            {
                items.Add(item);
                Console.WriteLine($"ĐÃ thêm sản phẩm {item.productName}!");

            }
        }
        public bool RemoveItem(ShoppingCartItem item)
        {
            var existing = items.FirstOrDefault(p => p.productId == item.productId);
            if (existing == null)
            {
                Console.WriteLine("Không có sản phẩm này");
                return false;
            }
            items.Remove(item);
            Console.WriteLine("ĐÃ xóa");
            return true;
        }
        public void UpdateItemQuantity(int productId,int quantity) // cập nhật số lượng trực tiếp
        {
            var item = items.FirstOrDefault(i => i.productId == productId);
            if (item == null)
            {
                Console.WriteLine("Nhót");
                Console.WriteLine("k thấy hàng trong giỏ");
                return;
            }
            if (quantity > 0)
            {
                item.quantity = quantity;
                Console.WriteLine("Đã cập nhật số lượng mới");
                return;
            }
            else
            {
                items.Remove(item);
                Console.WriteLine("Xóa sản phẩm do sản phẩm còn 0!");
                return;
            }


        }
        public void IncrementItemQuantity (int productId,int increment = 1)
        {
            var incr = items.FirstOrDefault (i => i.productId == productId);
            if (incr == null)
            {
                Console.WriteLine("k thay san pham");
                return;
            }
            incr.quantity += increment;
            Console.WriteLine("ĐÃ tăng");
            
        }
        public void DecrementItemQuantity(int productId, int decrement = 1)
        {
            var decr = items.FirstOrDefault(i => i.productId == productId);
            if (decr == null)
            {
                Console.WriteLine("k thay san pham");
                return;
            }
            decr.quantity -= decrement;
            Console.WriteLine("ĐÃ tăng");
            if (decr.quantity < 1)
            {
                items.Remove(decr);
            }
            return;

        }
        public void DisplayCart()
        {
            Console.WriteLine("\n--- Giỏ Hàng ---");
            if (items.Any())
            {
                foreach (var i in items)
                {
                    Console.WriteLine($"{i.productName}: {i.quantity} x {i.price} = {i.total}");
                }
            }
            else
            {
                Console.WriteLine("Giỏ hàng trống");
            }
        }
        public void ClearCart()
        {
            items.Clear();
            Console.WriteLine("Đã xóa hết item!");
        }
        public async Task<Order> ConfirmOrder(string CustomerName, IOrderManagement orderService)
        {
           // Tạo danh sách các item cho các item gồm id sản phẩm và số lượng
            var item = items.Select(i => (i.productId, i.quantity)).ToList();
            var order = await orderService.CreateOrder(CustomerName, item);
            if (order != null)
            {
                ClearCart();
                return await Task.FromResult(order);

            }

            return null;

        }// chuyển qua giao diện thanh toán sau khi xác nhận xong
    }
}
