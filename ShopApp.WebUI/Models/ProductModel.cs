using ShopApp.Entities;
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
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Ürün ismi minimum 5,max 100 karakter olmalıdır. (5<Name<100)")]       
        public string Name { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        [StringLength(100000, MinimumLength = 5, ErrorMessage = "Ürün açıklaması min 5,max 100000 karakter olmalıdır. (5<Description<100000)")]
        public string Description { get; set;}
        [Required(ErrorMessage ="Fiyat Belirtiniz.")]
        [Range(1,999999999999999)]
        public decimal? Price { get; set; }
        public List<Category> SelectedCategories { get; set; }
    }
}
