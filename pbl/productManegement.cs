using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl
{
    internal class productManegement
    {
        private List<product> products = new();
        private categoryManagement categoryService;
        public productManegement(categoryManagement categoryManagement)
        {
            categoryService = categoryManagement;
        }
        public void AddProduct(product product)
        {
            products.Add(product);
            Console.WriteLine("tao");
        }
        public product getProductId(int id)
        {
            return products.FirstOrDefault(p => p.id_product == id);
        }
        public List<product> SearchProducts(string keyword)
        {
            return products
                .Where(p => p.name_product.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
        public void DisplayAllProducts()
        {
            foreach (var product in products)
            {
                product.DisplayProduct();
            }
        }
        public product GetProductByName(string productname)
        {
            return products.FirstOrDefault(c => c.name_product.Equals(productname, StringComparison.OrdinalIgnoreCase));
        }
        public bool DeleteProduct(string name)
        {
            var product = GetProductByName(name);
            if (product != null)
            {
                products.Remove(product);
                Console.WriteLine($"🗑️ Đã xóa sản phẩm: {product.name_product}");
                return true;
            }
            Console.WriteLine("⚠️ Không tìm thấy sản phẩm để xóa!");
            return false;
        }
        public List<product> GetProductsByCategory(int categoryId)
        {
            return products.Where(p => p.CategoryId == categoryId).ToList();
        }
        public bool UpdateProduct(int productId, string newName, decimal newPrice,string descrip,int categoryId,decimal discount)
        {
            var product = getProductId(productId);
            if (product != null)
            {
                product.UpdateDiscount(discount);
                product.UpdateCategoryId(categoryId);
                product.UpdateNameProduct(newName);
                product.UpdateDecriptionProduct(descrip);
                product.UpdatePrice(newPrice);
                Console.WriteLine($"✅ Đã cập nhật sản phẩm: {product.name_product}");
                return true;
            }
            Console.WriteLine("⚠️ Không tìm thấy sản phẩm để cập nhật!");
            return false;
        }
        public bool UpdateDynamicAttribute(int productId, string attrName, object newValue)
        {
            var product = getProductId(productId);
            if (product != null)
            {
                product.AddOrUpdateAttribute(attrName, newValue);
                Console.WriteLine($"✅ Đã cập nhật thuộc tính {attrName} cho sản phẩm {product.name_product}");
                return true;
            }
            Console.WriteLine("⚠️ Không tìm thấy sản phẩm để cập nhật thuộc tính!");
            return false;
        }
        public List<product> GetProductsByCategoryId(int categoryId)
        {
            return products
                .Where(p => p.CategoryId == categoryId)
                .ToList();
        }
        public List<product> GetProductsByCategoryName(string categoryName)
        {
            var category = categoryService.GetCategoryByName(categoryName);
            if (category == null)
            {
                Console.WriteLine($"⚠️ Không tìm thấy danh mục '{categoryName}'");
                return new List<product>();
            }

            return products
                .Where(p => p.CategoryId == category.CategoryId)
                .ToList();
        }

        public void DisplayProductsByCategoryName(string categoryName)
        {
            var products = GetProductsByCategoryName(categoryName);
            if (products.Count == 0)
            {
                Console.WriteLine($"⚠️ Không có sản phẩm nào trong danh mục '{categoryName}'");
                return;
            }

            Console.WriteLine($"\n📂 Danh mục: {categoryName}");
            foreach (var product in products)
            {
                product.DisplayProduct();
            }
        }
    }

}