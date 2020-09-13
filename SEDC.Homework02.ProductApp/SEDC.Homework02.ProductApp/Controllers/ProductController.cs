using Microsoft.AspNetCore.Mvc;
using SEDC.Homework02.ProductApp.InMemoryDatabase;
using SEDC.Homework02.ProductApp.Models.Domain;
using SEDC.Homework02.ProductApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.Homework02.ProductApp.Controllers
{
    public class ProductController : Controller
    {

        [HttpGet("CreateProduct")]
        public IActionResult CreateProduct(string error)
        {
            ViewBag.Error = error;

            return View();
        }

        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct(CreateProductVM createProduct)
        {
            var product = new Product()
            {
                Id = Database.Products.Count + 1,
                Name = createProduct.Name,
                Description = createProduct.Description,
                Category = createProduct.Category,
                Price = createProduct.Price
            };

            if (product.Name == null && product.Price == 0)
            {
                return RedirectToAction("CreateProduct", new { error = "No product was added!" });
            }

            Database.Products.Add(product);

            return RedirectToAction("Index", "Home", new { message = $"The product {product.Name} was succesfully created!" });
        }

        [HttpGet("ProductDetails/{id:int}")]
        public IActionResult ProductDetails(int id)
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
            //var productVM1 = Database.Products.Select(p => new ProductVM()
            //{
            //    Id = p.Id,
            //    Name = p.Name,
            //    Description = p.Description,
            //    Category = p.Category,
            //    Price = p.Price
            //});

            ProductVM productVM1 = productList.SingleOrDefault(p => p.Id == id);

            return View("_productItemPartial", productVM1);

        }

    }
}
