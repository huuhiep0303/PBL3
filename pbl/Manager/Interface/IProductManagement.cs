using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inforProduct;

namespace pbl.Manager.Interface
{
    internal interface IProductManagement
    {
        Task<bool> AddProduct(product product);
        Task<bool> DeleteProductByName(string name);
        Task<product> GetProductById(int id);
        Task<List<product>> SearchProducts(string keyword);
        Task<bool> UpdateProduct(int productId, product updatedProduct);
        Task<bool> UpdateDynamicAttribute(int productId, string attrName, object value);
        Task<List<product>> GetProductsByCategoryName(string categoryName);
        Task<List<product>> GetProductsByCategoryId(int categoryid);
        Task DisplayProductsByCategoryName(string categoryName);
    }
}
