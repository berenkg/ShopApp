using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60,ErrorMessage ="Ürün ismi minimum 10 karakter ve max 60 olmalı", MinimumLength =10)]
        public string Name { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage ="Fiyat belirtiniz")]
        [Range(1,10000)]
        public decimal? Price { get; set; }
        [Required]
        public string Description { get; set; }

    }
}
