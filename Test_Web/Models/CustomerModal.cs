using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Web.Models
{
    public class CustomerModal
    {
        [Required(ErrorMessage = "First name is required")]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z.'\s]+$", ErrorMessage = "Only alphabet, comma, single quote and space allowed. First character shoulde be alphabet.")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z.'\s]+$", ErrorMessage = "Only alphabet, comma, single quote and space allowed. First character shoulde be alphabet.")]
        public string lastName { get; set; }
    }
}
