using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace assignment_5.Models
{
    //Class with atomic fields and required tags when needed
    //All properties are required. (Other than Middle Initial and maybe First Name.)
    public class Book
    {
        //Primary Key is correctly named and identified in model
        [Key][Required]
        public int BookID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        public string AuthorFirst { get; set; }


        public string AuthorMiddle { get; set; }

        [Required]
        public string AuthorLast { get; set; }

        //ISBN property contains validation
        [Required] [RegularExpression(@"^[0-9]{3}(-[0-9]{10})$", ErrorMessage = "Please use the specified ISBN format")]
        public string ISBN { get; set; }

        [Required]
        public string Classification { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public decimal Price { get; set; }

        //New Number of Pages attribute
        public int NumberOfPages { get; set; }
    }
}
