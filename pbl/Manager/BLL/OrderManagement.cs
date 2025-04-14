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
    internal class OrderManagement : IOrderManagement
    {
        private readonly IInventoryManagement imService;
        private readonly IProductManagement pmService;
        private readonly List<Order> orders = new();

        public OrderManagement(IProductManagement pmService, IInventoryManagement imService)
        {
            this.imService = imService;
            this.pmService = pmService;
        }
        public async Task<Order> GetOrderById(int id)
        {
            return await Task.FromResult(orders.FirstOrDefault(p => p.OrderId == id));
        }
        public async Task<List<Order>> GetOrderByDateTime(DateTime date)
        {
            return await Task.FromResult(orders.Where(p => p.OrderDate == date).ToList());
        }

        //khi khách hoặc nhân viên xác nhận những gì đã mua, gọi hàm này để tạo đơn hàng 
        public async Task<Order> CreateOrder(string customerName, List<(int productID,int quantity)> items)
        {
            var order = new Order(customerName);
            foreach (var (productID,quantity) in items)
            {
                var product = await pmService.GetProductById(productID);
                if (product == null)
                {
                    Console.WriteLine("Sản phẩm không hợp lệ");
                    return null;
                }
                var check = await imService.ReduceOrSaleStock(productID, quantity,"SALE");
                if (!check)
                {
                    Console.WriteLine("Hết hàng!");
                    return null;
                }
                order.AddItem(new OrderItem(productID,product.name_product,product.price,quantity));
                

            }
            orders.Add(order);
            
            Console.WriteLine($"Tạo đơn cho khách hàng: {customerName}, đơn hàng ở trạng thái: {order.status}");
            return order;

        }
        public async Task DisplayAllOrder()
        {
            foreach (var order in orders)
            {
                order.DisplayOrder();
            }
            return;
        }
        public async Task DisplayOrderByDate(DateTime date)
        {
            var orderdate = await GetOrderByDateTime(date);
            foreach (var item in orderdate)
            {
                item.DisplayOrder();
            }
            return;
        }
        public async Task<bool> DeleteOrder(int orderID)
        {
            var order = orders.FirstOrDefault(p => p.OrderId == orderID);
            if(order == null)
            {
                Console.WriteLine("Đơn hàng này không tồn tại");
                return await Task.FromResult(false);
            }
            orders.Remove(order);
            Console.WriteLine("Đã xóa!");
            return await Task.FromResult(true);
        }


    }
}
