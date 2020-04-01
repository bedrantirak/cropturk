using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Models
{
    public class CategoryListModel
    {
        [Display(Name = "Kategoriler")]
        public List<Category> Categories { get; set; }
    }
}
