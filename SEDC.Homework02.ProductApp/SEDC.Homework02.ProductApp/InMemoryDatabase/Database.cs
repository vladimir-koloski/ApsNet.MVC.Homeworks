using SEDC.Homework02.ProductApp.Models.Domain;
using SEDC.Homework02.ProductApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.Homework02.ProductApp.InMemoryDatabase
{
        public static class Database
        {
            
            public static List<Product> Products;
            

            static Database()
            {
               

                Products = new List<Product>()
            {
                new Product()
            {
                Id = 1,
                Name = "Tennis",
                Price = 7,
                Category = Category.Sport
            },
                new Product()
                {
                    Id = 2,
                    Name = "Robinson Crouso",
                    Price = 8,
                    Category = Category.Books
                },
                new Product()
                {
                    Id = 3,
                    Name = "TV",
                    Price = 200,
                    Category = Category.Electronics
                },
                new Product()
                {
                    Id = 4,
                    Name = "Cafetin",
                    Price = 2,
                    Category = Category.Pharmacy
                },
                new Product()
            {
                Id = 5,
                Name = "PC",
                Price = 3200,
                Category = Category.Electronics
            },
                new Product()
                {
                    Id = 6,
                    Name = "Bike",
                    Price = 120,
                    Category = Category.Sport
                },
                new Product()
                {
                    Id = 7,
                    Name = "Vitamin C",
                    Price = 3,
                    Category = Category.Pharmacy
                },
                new Product()
                {
                    Id = 8,
                    Name = "Book for jungle",
                    Price = 7,
                    Category = Category.Books
                },
                new Product()
                {
                    Id = 9,
                    Name = "Mouse",
                    Price = 5,
                    Category = Category.Electronics
                },
                
            };

            }
        }
    
}
