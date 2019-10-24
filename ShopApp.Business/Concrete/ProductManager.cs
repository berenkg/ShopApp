﻿using ShopApp.Business.Abstract;
using ShopApp.Entities;
using ShoppApp.DataAccess.Abstract;
using ShoppApp.DataAccess.Concrete.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        ///////////////////////////////////////////////////////////////////////////
        //Bir concrete sınıf ile başka bir concrete sınıfı asla birbirine bağlama.
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        //////////////////////////////////////////////////////////////////////////

        public void Create(Product entity)
        {
            _productDal.Create(entity);
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity);

        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll().ToList();
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public Product GetProductDetails(int id)
        {
            return _productDal.GetProductDetails(id);
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
