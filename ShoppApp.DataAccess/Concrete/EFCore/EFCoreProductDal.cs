using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using ShoppApp.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShoppApp.DataAccess.Concrete.EFCore
{
    public class EFCoreProductDal : EFCore_GenericRepository<Product, ShopContext>, IProductDal
    {
        public IEnumerable<Product> GetPopularProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProductDetails(int id)
        {
            using (var context = new ShopContext())
            {
                return context.Products
                    .Where(i => i.Id == id)
                    .Include(i => i.ProductCategories)//Product.ProductCategories
                    .ThenInclude(i => i.Category)//ProductCategories.Category
                    .FirstOrDefault();
            }
        }
    }
}
