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

        public List<Product> GetProductsByCategory(string category, int page = 1, int pageSize=3)
        {
            using (var context = new ShopContext())
            {
                var products = context.Products.AsQueryable();

                if(!string.IsNullOrEmpty(category))
                {
                    products = products
                        .Include(i => i.ProductCategories)
                        .ThenInclude(i => i.Category)
                        .Where(i => i.ProductCategories.Any(a => a.Category.Name.ToLower() == category.ToLower()));
                }
                return products.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            }
        }
    }
}
