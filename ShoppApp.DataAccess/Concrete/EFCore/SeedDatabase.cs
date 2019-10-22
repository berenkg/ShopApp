using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppApp.DataAccess.Concrete.EFCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();

            if(context.Database.GetPendingMigrations().Count()==0)
            {
                if(context.Categories.Count()==0)
                {
                    context.Categories.AddRange(Categories);
                }

                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                }
                context.SaveChanges();
            }
        }

        private static Category[] Categories =
        {
            new Category(){Name="Telefon" },
            new Category(){Name="Bilgisayar" }
        };

        private static Product[] Products=
        {
            new Product(){Name="Samsung S6", ImageUrl="-", Price=2000},
            new Product(){Name="Samsung S7", ImageUrl="-", Price=1000},
            new Product(){Name="Samsung S8", ImageUrl="-", Price=3000},
            new Product(){Name="Samsung S9", ImageUrl="-", Price=4000},
            new Product(){Name="Samsung S1", ImageUrl="-", Price=5000},
            new Product(){Name="Samsung S", ImageUrl="-", Price=9000},
            new Product(){Name="Samsung S2", ImageUrl="-", Price=7000},
            new Product(){Name="Samsung S3", ImageUrl="-", Price=8000},
        };

    }
}
