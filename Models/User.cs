using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task19_MVC.Models
{
    public class User
    {
        [Required(ErrorMessage = "*")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "*")]
        public string PaymentMode { get; set; }

        [Display(Name = "Card Type")]
        [Required(ErrorMessage = "*")]

        public int CardType { get; set; }
        public List<SelectListItem> CardTypeList { get; set; }

    }
}