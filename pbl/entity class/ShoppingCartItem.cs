using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl.entity_class
{
    internal class ShoppingCartItem // giống order , nhưng để tạm thời , đến khi xác nhận thành order mới bắt đầu xử lý nghiệp vụ liên quan khác
    {
        public int productId {  get; set; }
        public string productName { get; set; }
        public decimal price { get; set; }// giá 1 đơn vị sản phẩm
        public int quantity { get; set; }
        public decimal total => price * quantity;

        public ShoppingCartItem(int productId, string productName, decimal price, int quantity)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
        }


    }
}
