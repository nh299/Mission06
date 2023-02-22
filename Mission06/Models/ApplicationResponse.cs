using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int ApplicationId { get; set; }
        [Required(ErrorMessage = "You're going to enter a movie without its name??")]
        public string Title { get; set; }
        [Required(ErrorMessage = "You need to provide the year of the film")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Please enter the director")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Please Select a Rating")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }

        //Building a Foreign Key relationship
        [Required(ErrorMessage ="Please Select a Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
