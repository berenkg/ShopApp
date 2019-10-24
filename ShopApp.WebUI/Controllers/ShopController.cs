using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.Entities;
using ShopApp.WebUI.Models;

namespace ShopApp.WebUI.Controllers
{
    public class ShopController : Controller
    {
        private IProductService _productService;

        public ShopController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var sonuc = new ProductListModel()
            {
                Products = _productService.GetAll()
            };
            return View(sonuc);
        }
        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            Product product = _productService.GetProductDetails((int)id);
            if(product == null)
            {
                return NotFound();
            }
            var a = id;
            var b = product;
            return View(new ProductCategoryModel()
            {
                Product = product,
                Categories = product.ProductCategories.Select(i => i.Category).ToList()
                //product.ProductCategories Dediğimiz anda aslında produclara göre olan Category tablosu seçildi
                //ToList ile liste halinde geri döndürdük.
            }
            );
        }
    }
}