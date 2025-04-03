using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inforProduct
{
    public class product
    {
        public int id_product { get;set; }
        public string name_product { get; set; }
        public string description_product { get; set; }
        public int CategoryId { get; set; }
        public decimal price { get; set; }
        public decimal stockQuantity { get; set; }
        public bool isAvailable { get; set; }
        protected decimal discount { get; set; }
        protected decimal ReorderLevel { get; set; }
        public Dictionary<string, object> DynamicAttributes { get; set; } = new();
        protected bool isOnlineSale {  get; set; }

        protected product Next;

        public product(int Id_product, string Name_product, string Description_product, int categoryId, decimal Price, bool IsAvailable, decimal StockQuantity,
            decimal Discount, bool IsOnlineSale, decimal reorderlevel, product Next)
        {
            this.CategoryId = categoryId;
            this.id_product = Id_product;
            this.price = Price;
            this.name_product = Name_product;  
            this.description_product = Description_product;
            this.stockQuantity = StockQuantity;
            this.isAvailable = IsAvailable;
            this.isOnlineSale = IsOnlineSale;
            this.discount = Discount;
            this.ReorderLevel = reorderlevel;
            this.Next = Next
        }
        public void UpdateNameProduct(string nName_product) => name_product = nName_product;
        public void UpdateDecriptionProduct(string decrip) => description_product = decrip;
        public void UpdateCategoryId(int id) => CategoryId = id;
        public void UpdatePrice(decimal nprice) => price = nprice;
        public void UpdateDiscount(decimal ndiscount) => discount = ndiscount;
        //public void UpdateBasicInfo
        public void AddOrUpdateAttribute(string key, object value)
        {
            DynamicAttributes[key] = value;
        }
        public void DisplayProduct()
        {
            Console.WriteLine("Id danh muc: {0}", CategoryId);
            Console.WriteLine("id san pham: {0}", id_product);
            Console.WriteLine("Gia: {0}", price);
            Console.WriteLine("Ten san pham: {0}", name_product);
            Console.WriteLine("Mo ta: {0}", description_product);
            Console.WriteLine("Hang con trong kho: {0}",stockQuantity);

            if (isAvailable)
                Console.WriteLine("Hang da het");
            else
                Console.WriteLine("Con hang");
            if (isOnlineSale) Console.WriteLine("co ban on");
            else Console.WriteLine("K ban online");
            Console.WriteLine("Giam gia: {0}%", discount);
            if (DynamicAttributes.Any())
            {
                Console.WriteLine("🔎 Thuộc tính mở rộng:");
                foreach (var attr in DynamicAttributes)
                {
                    Console.WriteLine($" - {attr.Key}: {attr.Value}");
                }
            }
        }
        public void UpdateStock(int quantity)
        {
            stockQuantity += quantity;
            isAvailable = stockQuantity > 0;
        }
        public decimal getDiscountedPrice()
        {
            return price - (price * discount / 100);
        }
        public bool NeedsRestock()
        {
            return stockQuantity <= ReorderLevel;
        }
    };

    class productList{
        protected product head;
        protected void addProduct(int id_product, string name_product){
            product newProduct = new product(id_product, name_product);
            if(head == null) head = newProduct;
            else{
                product temp = head;
                while(temp != null){
                    temp = text.Next;
                }
                temp.Next = newProduct;
            }
        }

        protected void removeProduct (int id_product){

            if(head == null) return;

            if(head.id_product == id_product){
                head = head.Next;
                return;
            }

            product temp = head;
            product prev = null; //dùng để gán tạm thời khi tìm được node cần xoá
            while(temp != null && temp.id_product != id_product){
                prev = temp;
                temp = temp.Next;
            }
            if(temp == null) {
                Console.WriteLine("Không tìm thấy sản phẩm để xoá");
                return;
            }
            prev.Next = temp.Next;//xoá thành công
            Console.WriteLine("Đã xoá thành công.");
        }
        
    }
}
