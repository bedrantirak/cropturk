
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Models
{
    public class OrderModel
    {
        
        [Display(Name ="İsim")]
        public string FirstName { get; set; }
        [Display(Name = "Soyisim")]
        public string LastName { get; set; }
        [Display(Name = "Adres")]
        public string Address { get; set; }
        [Display(Name = "Şehir")]
        public string City { get; set; }
        [Display(Name = "Telefon Numarası")]
        public string Phone { get; set; }
        [Display(Name = "Email Adresi")]
        public string Email { get; set; }
        [Display(Name = "Kart Üzerindeki İsim Soyisim")]
        public string CardName { get; set; }
        [Display(Name = "Kart Numarası")]
        public string CardNumber { get; set; }
        [Display(Name = "Kart Son Kullanım Ayı")]
        public string ExpirationMonth { get; set; }
        [Display(Name = "Kart Son Kullanım Yılı")]
        public string ExpirationYear { get; set; }
        [Display(Name = "CVC Kodu")]
        public string Cvv { get; set; }

        public CartModel CartModel { get; set; }
    }
}
