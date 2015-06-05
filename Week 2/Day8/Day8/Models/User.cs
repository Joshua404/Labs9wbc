using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day8.Models
{
    public class User: IValidatableObject
    {

        [Remote("ValidateUsername", "Users", ErrorMessage="Allready Taken!", HttpMethod="POST")]
        public string Username { get; set; }

        [Required]
        public string Comments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            if (!this.Comments.Contains("good")) {
                results.Add(new ValidationResult("Bad Comment!", new string[] { "Comments" }));
            }
            return results;
        }
    }
}