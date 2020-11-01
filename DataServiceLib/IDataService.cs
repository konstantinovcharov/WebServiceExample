using System;
using System.Collections.Generic;
using System.Text;

namespace DataServiceLib
{
    public interface IDataService
    {
        IList<Category> GetCategories();
        Category GetCategory(int id);
        IList<Product> GetProducts();
        Product GetProduct(int id);

        void CreateCategory(Category category);
        bool UpdateCategory(Category category);
        bool DeleteCategory(int id);
    }
}
