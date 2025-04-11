using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inforProduct
{
    internal class categoryManagement
    {
        private List<category> categories = new();
        
        
        public void addCategory(category category)
        {
            categories.Add(category);
            Console.WriteLine($"Da them danh muc: {category.CategoryName}");
        }
        public category getCategoryId(int categoryid)
        {
            return categories.FirstOrDefault(c => c.CategoryId == categoryid);
        }
        public void DisplayAllCategories()
        {
            foreach (var category in categories)
            {
                category.DisplayCategory();
            }
        }
        public bool DeleteCategory(int categoryId)
        {
            var category = getCategoryId(categoryId);
            if (category != null)
            {
                categories.Remove(category);
                Console.WriteLine($"🗑️ Đã xóa danh mục: {category.CategoryName}");
                return true;
            }
            Console.WriteLine("⚠️ Không tìm thấy danh mục để xóa!");
            return false;
        }
        public List<category> serchCategoty(string category_name)
        {
            return categories.Where(c => c.CategoryName.Contains(category_name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public category GetCategoryByName(string categoryName)
        {
            return categories.FirstOrDefault(c => c.CategoryName.Equals(categoryName, StringComparison.OrdinalIgnoreCase));
        }
        
    }
}
