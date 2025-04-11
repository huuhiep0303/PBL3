using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace inforProduct
{
    internal class category
    {
        public int CategoryId {  get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; } = string.Empty;
        
        public List<product> products { get; set; }
        public category(int categoryid, string categoryName,List<product> Products, string categoryDescription)
        {
            products = Products ?? new List<product>();
            CategoryId = categoryid;
            CategoryName = categoryName;
            CategoryDescription =    categoryDescription;


        }
        public void DisplayCategory()
        {
            Console.WriteLine($"📁 [{CategoryId}] {CategoryName} - {CategoryDescription}");
            if (products.Any())
            {
                Console.WriteLine("📦 Danh sách sản phẩm:");
                foreach (var p in products)
                {
                    Console.WriteLine($" - {p.name_product} (ID: {p.id_product}, Giá: {p.price})");
                }
            }
            else
            {
                Console.WriteLine("⚠️ Chưa có sản phẩm nào trong danh mục này.");
            }
        }
    }


}
