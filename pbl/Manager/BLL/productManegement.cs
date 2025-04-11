using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inforProduct;
using pbl.Manager.Interface;


//cứ dùng các list để lưu các danh sách như là danh sách hàng, thông tinh nhân viên, các list đó sẽ được kết nối để lấy thông tin tử csdl sau
namespace pbl.Manager.BLL
{
    internal class productManagement : IProductManagement
    {
        //List<category> categoryList;
        private readonly List<product> products = new();
        private readonly categoryManagement categoryService;
        private readonly InventoryManagement inventoryService;
        public productManagement(categoryManagement categoryManagement,InventoryManagement inventoryService)
        {
            categoryService = categoryManagement;
            this.inventoryService = inventoryService;
        }
        public async Task<bool> AddProduct(product product)
        {
            if (!await categoryService.IsCategoryExist(product.CategoryId))
            {
                Console.WriteLine("Không tồn tại danh mục");
                return false;
            }

            if (products.Any(p => p.id_product == product.id_product)){
                Console.WriteLine("Sản phẩm đã tồn tại");
                return false;
            }
            var Category = await categoryService.GetCategoryById(product.CategoryId);
            if (Category == null)
            {
                Console.WriteLine("không lấy được thông tin danh mục");
                return false;
            }
            product.CategoryInfo = Category;
            Category.products.Add(product);
            products.Add(product);
            Console.WriteLine("Thêm 1 sản phẩm");
            await inventoryService.CreateRecord(product.id_product, initialQuantity: 0, reorderQuantity: 30);
            return await Task.FromResult(true);
            
        }
        public async Task<product> GetProductById(int id)
        {
            return await Task.FromResult(products.FirstOrDefault(p => p.id_product == id));
        }
        public async Task<List<product>> SearchProducts(string keyword)// tìm kiếm theo tên(cụ thể là keyword}
        {
            return await Task.FromResult(
            products.Where(p => p.name_product.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList()
        );
        }
        public void DisplayAllProducts()
        {
            foreach (var product in products)
            {
                product.DisplayProduct();
            }
        }
        //public product GetProductByName(string productname)
        //{
        //    return products.FirstOrDefault(c => c.name_product.Equals(productname, StringComparison.OrdinalIgnoreCase));
        //}
        public async Task<bool> DeleteProductByName(string name)
        {
            var product = products.FirstOrDefault(c => c.name_product.Equals(name, StringComparison.OrdinalIgnoreCase)); ;
            if (product != null)
            {
                products.Remove(product);
                Console.WriteLine($"🗑️ Đã xóa sản phẩm: {product.name_product}");
                return await Task.FromResult(true);
            }
            Console.WriteLine("⚠️ Không tìm thấy sản phẩm để xóa!");
            //FOREIGN KEY(ProductId) REFERENCES Product(ProductId) ON DELETE CASCADE (dùng cho database ,
            //để xóa những j liên quan đến nó) 
            //note lại kẻo quên

            return await Task.FromResult(false);
        }
        public async Task<List<product>> GetProductsByCategoryId(int categoryId)
        {
            return await Task.FromResult(products.Where(p => p.CategoryId == categoryId).ToList());
        }
        public async Task<bool> UpdateProduct(int productId, product updated)
        {
            var product = products.FirstOrDefault(p => p.id_product == productId);
            if (product == null)
            {
                Console.WriteLine("⚠️ Không tìm thấy sản phẩm để cập nhật!");
                return await Task.FromResult(false);
            }

            product.name_product = updated.name_product;
            product.description_product = updated.description_product;
            product.price = updated.price;
            product.CategoryId = updated.CategoryId;
            product.discount = updated.discount;
            product.isAvailable = updated.isAvailable;

            Console.WriteLine($"✅ Đã cập nhật sản phẩm: {product.name_product}");
            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateDynamicAttribute(int productId, string attrName, object newValue)
        {
            var product = products.FirstOrDefault(p => p.id_product == productId);
            if (product != null)
            {
                product.AddOrUpdateAttribute(attrName, newValue);
                Console.WriteLine($"✅ Đã cập nhật thuộc tính {attrName} cho sản phẩm {product.name_product}");
                return true;
            }
            Console.WriteLine("⚠️ Không tìm thấy sản phẩm để cập nhật thuộc tính!");
            return false;
        }
        
        public async Task<List<product>> GetProductsByCategoryName(string categoryName)
        {
            var category = await categoryService.GetCategoryByName(categoryName);
            if (category == null)
            {
                Console.WriteLine($"⚠️ Không tìm thấy danh mục '{categoryName}'");
                return new List<product>();
            }
 
            return await Task.FromResult(products
                .Where(p => p.CategoryId == category.CategoryId)
                .ToList());
        }

        public async Task DisplayProductsByCategoryName(string categoryName)
        {
            var list = await GetProductsByCategoryName(categoryName);
            if (list.Count == 0)
            {
                Console.WriteLine("⚠️ Không có sản phẩm nào trong danh mục này.");
                return;
            }

            Console.WriteLine($"\n📂 Danh mục: {categoryName}");
            foreach (var product in list)
            {
                product.DisplayProduct();
            }
        }
    }

}