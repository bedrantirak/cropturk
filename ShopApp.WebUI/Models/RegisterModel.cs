using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Models
{
    public class RegisterModel
    {
        [Required]
        [Display(Name = "Ad Soyad")]
        public string FullName { get; set; }
        [Required]
        [Display(Name = "Kullanıcı Adı")]
        public string Username { get; set; }
        [Required]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Tekrar Şifre")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string RePassword { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
