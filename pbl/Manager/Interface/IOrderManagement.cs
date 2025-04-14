using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pbl.entity_class;

namespace pbl.Manager.Interface
{
    internal interface IOrderManagement
    {
        Task<Order> GetOrderById(int id);
        Task<List<Order>> GetOrderByDateTime(DateTime date);
        Task<Order> CreateOrder(string customerName, List<(int productID, int quantity)> items);
        Task DisplayAllOrder();
        Task DisplayOrderByDate(DateTime date);
        Task<bool> DeleteOrder(int orderID);
    }
}
