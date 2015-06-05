using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day8Labs.Models
{
    public class NewAccountVM
    {
        //public NewAccount NewAccount { get; set; }

        //public NewAccountVM()
        //{
        //    this.NewAccount = new NewAccount();
        //}


        [Remote("ValidateUsername", "NewAccount", ErrorMessage = "Allready Taken!", HttpMethod = "POST")]
        public string Username { get; set; }

        [Required]
        public string FirstName { get; set; }

        [MinLength(5)]
        [Required]
        public string LastName { get; set; }

        //[CreditCard]
        public string CreditCard { get; set; }


        [Required]
        public string Password { get; set; }

        [Required]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "The Passwords Do Not Match")]
        public string ConfirmPassword { get; set; }

        [RegularExpression(@"^(?!000)(?!666)(?!9)[X0-9]{3}([- ]?)(?!00)[X0-9]{2}\1(?!0000)\d{4}$")]
        public string SSN { get; set; }

        [MaxLength(50)]
        public string Comments { get; set; }
    }
}