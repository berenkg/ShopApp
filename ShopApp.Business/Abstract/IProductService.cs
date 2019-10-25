using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        Product GetProductDetails(int id);
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);

        List<Product> GetProductsByCategory(string category, int page = 1, int pageSize=3);
    }
}
