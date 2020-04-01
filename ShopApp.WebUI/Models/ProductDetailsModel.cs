using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Models
{
    public class ProductDetailsModel
    {
        [Display(Name = "Ürün")]
        public Product Product { get; set; }
        [Display(Name = "Kategoriler")]
        public List<Category> Categories { get; set; }
    }
}
