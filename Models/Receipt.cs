using System;
using System.ComponentModel.DataAnnotations;

namespace PersianDateTimePickerDemo.Models
{
    public class Receipt
    {
        [Display(Name = "تاریخ پرداخت")]
        [Required(ErrorMessage = "وارد کردن تاریخ الزامی است.")]
        public DateTime LastPayment { get; set; }
    }
}
