using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.Homework02.ProductApp.InMemoryDatabase;
using SEDC.Homework02.ProductApp.Models;
using SEDC.Homework02.ProductApp.Models.Domain;
using SEDC.Homework02.ProductApp.Models.ViewModels;

namespace SEDC.Homework02.ProductApp.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index(string message)
        {
            var productList = new List<ProductVM>();

            foreach (var product in Database.Products)
            {
                var productVM = new ProductVM()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Category = product.Category,
                    Price = product.Price
                };

                productList.Add(productVM);
            }

            var products = new ProductListVM()
            {
                Products = productList
            };

            ViewBag.Message = message;

            return View("Index", products);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
