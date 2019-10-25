using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShoppApp.DataAccess.Abstract
{
    public interface IProductDal:IRepository<Product>
    {
        IEnumerable<Product> GetPopularProducts();

        List<Product> GetProductsByCategory(string category);

        Product GetProductDetails(int id);
    }
}
