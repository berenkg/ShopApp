﻿using ShopApp.Entities;
using ShoppApp.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ShoppApp.DataAccess.Concrete.Memory
{
    public class MemoryProductDal : IProductDal
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }


        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetOne(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetPopularProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProductDetails(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategory(string category, int page = 1, int pageSize = 0)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        List<Product> IRepository<Product>.GetAll(Expression<Func<Product, bool>> filter)
        {
            var product = new List<Product>()
            {
                new Product() {Id=1, Name="Samsung S6", ImageUrl="-", Price=100},
                new Product() {Id=2, Name="Samsung S7", ImageUrl="-", Price=100},
                new Product() {Id=3, Name="Samsung S8", ImageUrl="-", Price=100},
                new Product() {Id=4, Name="Samsung S9", ImageUrl="-", Price=100}
            };

            return product;
        }
    }
}
