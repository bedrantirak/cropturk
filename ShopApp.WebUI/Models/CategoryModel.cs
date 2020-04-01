using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        [Display(Name = "Kategori Adı")]
        public string Name { get; set; }
        [Display(Name = "Ürünler")]

        public List<Product> Products { get; set; }
    }
}
