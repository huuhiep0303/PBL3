using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inforProduct;
using pbl.Manager.Interface;
namespace pbl.Manager.BLL
{
    internal class categoryManagement : ICategoryManagement
    {
        private readonly List<category> categories = new();

        public async Task<bool> IsCategoryExist(int categoryId)
        {
            return await Task.FromResult(categories.Any(c => c.CategoryId == categoryId));
        }
        public async Task<bool> AddCategory(category category)
        {
            if (categories.Any(c => c.CategoryName.Equals(category.CategoryName, StringComparison.OrdinalIgnoreCase))){

                Console.WriteLine("Danh mục đã tồn tại");
                return false;
            }
            categories.Add(category);
            Console.WriteLine($"Da them danh muc: {category.CategoryName}");
            return await Task.FromResult(true);
        }
        public async Task<category?> GetCategoryById(int categoryid)
        {
            return await Task.FromResult(categories.FirstOrDefault(c => c.CategoryId == categoryid));
        }
        public async Task<category> GetCategoryByName(string categoryName)
        {
            return await Task.FromResult(
                categories.FirstOrDefault(c => c.CategoryName.Equals(categoryName, StringComparison.OrdinalIgnoreCase)));
        }
        public void DisplayAllCategories()
        {
            foreach (var category in categories)
            {
                category.DisplayCategory();
            }
        }
        public async Task<List<category>> GetAllCategories()
        {
            return await Task.FromResult(categories.ToList());
        }
        public async Task<bool> DeleteCategory(int categoryId)
        {
            var category = await GetCategoryById(categoryId);
            if (category != null)
            {
                categories.Remove(category);
                Console.WriteLine($"🗑️ Đã xóa danh mục: {category.CategoryName}");
                return true;
            }
            Console.WriteLine("⚠️ Không tìm thấy danh mục để xóa!");
            return false;
        }
        public async Task<List<category>> SearchCategory(string category_name)
        {
            return await Task.FromResult(
                categories.Where(c => c.CategoryName.Contains(category_name, StringComparison.OrdinalIgnoreCase)).ToList());
        }
        public async Task<bool> UpdateCategory(int id, string newName, string newDesc)
        {
            var category = await GetCategoryById(id);
            if (category != null)
            {
                category.CategoryName = newName;
                category.CategoryDescription = newDesc;
                Console.WriteLine($"✅ Đã cập nhật danh mục: {category.CategoryName}");
                return true;
            }

            Console.WriteLine("⚠️ Không tìm thấy danh mục để cập nhật!");
            return false;
        }


    }
}
