using SEDC.Homework02.ProductApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.Homework02.ProductApp.Models.ViewModels
{
    public class CreateProductVM
    {
        [Required(ErrorMessage = "The input Name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Price")]
        public double Price { get; set; }
        [Display (Name = "Enter Description of product")]
        public string Description { get; set; }
        [Display()]
        public Category Category { get; set; }
    }
}
