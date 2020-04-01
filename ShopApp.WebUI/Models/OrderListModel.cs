using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Models
{
    public class OrderListModel
    {
        [Display(Name = "Sipariş Id")]
        public int OrderId { get; set; }
        [Display(Name = "Sipariş Numarası")]
        public string OrderNumber { get; set; }
        [Display(Name = "Sipariş Tarihi")]
        public DateTime OrderDate { get; set; }
        [Display(Name = "Sipariş Durumu")]
        public EnumOrderState OrderState { get; set; }
        [Display(Name = "Ödeme Tipi")]
        public EnumPaymentTypes PaymentTypes { get; set; }
        [Display(Name = "İsim")]
        public string FirstName { get; set; }
        [Display(Name = "Soyisim")]
        public string LastName { get; set; }
        [Display(Name = "Adres")]
        public string Address { get; set; }
        [Display(Name = "Şehir")]
        public string City { get; set; }
        [Display(Name = "Telefon no")]
        public string Phone { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Sipariş Notu")]
        public string OrderNote { get; set; }

        public List<OrderItemModel> OrderItems { get; set; }
        public decimal TotalPrice()
        {
            return OrderItems.Sum(i => i.Price * i.Quantity);
        }

    }

    public class  OrderItemModel
    {
        public int OrderItemId { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }
    }
}
