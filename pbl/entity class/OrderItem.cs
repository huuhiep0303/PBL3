using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl.entity_class
{
    internal class OrderItem
    {
        public int OrderItemId {  get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; } // Giá trên 1 đơn vị sản phẩm
        public int Quantity { get; set; } // số lượng hàng mua
        public decimal Total => UnitPrice * Quantity; // tổng tiền

        public OrderItem(int productid, string name, decimal unitPrice, int quantiry) 
        {
            ProductId = productid;
            ProductName = name;
            UnitPrice = unitPrice;
            Quantity = quantiry;

        
        }
    }
}
