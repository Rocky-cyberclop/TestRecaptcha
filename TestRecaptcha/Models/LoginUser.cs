using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestRecaptcha.Models
{
    public class LoginUser
    {
        [DisplayName("Username")]
        [Required(ErrorMessage = "KHông được trống tên")]
        public string userName { get; set; }
        [DisplayName("Password")]
        public string password { get; set; }
        
    }
}