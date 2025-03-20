using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pbl
{
    internal class category
    {
        public int CategoryId {  get; set; }
        public string CategoryName { get; set; }
        protected string CategoryDescription { get; set; } = string.Empty;

        protected List<product> products { get; set; }
        public category(int categoryid, string categoryName,List<product> Products, string categoryDescription)
        {
            products = Products;
            CategoryId = categoryid;
            CategoryName = categoryName;
            CategoryDescription = categoryDescription;


        }
        public void DisplayCategory()
        {
            Console.WriteLine($"[{CategoryId}] {CategoryName} - {CategoryDescription}");
            Console.WriteLine($"Các thuộc tính động cho phép: {string.Join(", ", products)}");
        }
    }


}
