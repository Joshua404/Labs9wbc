using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day8Labs.Models
{
    public class NewAccount
    {
        [Remote("ValidateUsername", "Users", ErrorMessage = "Allready Taken!", HttpMethod = "POST")]
        public string Username { get; set; }

        [Required]
        public string FirstName { get; set; }

        [MinLength(5)]
        [Required]
        public string LastName { get; set; }

        [CreditCard]
        public string CreditCard { get; set; }


        [Required]
        public string Password { get; set; }

        [Required]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "The Passwords Do Not Match")]
        public string ConfirmPassword { get; set; }

        [RegularExpression(@"\d{3})[^\d]?(\d{2})[^\d]?(\d{4}")]
        public string SSN { get; set; }

        [MaxLength]
        public string Comments { get; set; }

    }
}