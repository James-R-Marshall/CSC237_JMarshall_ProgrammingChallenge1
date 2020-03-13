using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_JMarshall_ProgrammingChallenge1.Models
{
    public class Contact
    {
        public int contactID { get; set; }
        [Required(ErrorMessage ="You Must Enter a First Name")]
        public string firstName { get; set; }
        [Required(ErrorMessage = "You Must Enter a Last Name")]
        public string lastName { get; set; }
        [Required(ErrorMessage = "You Must Enter a Phone Number")]
        public string phone { get; set; }

        [Required(ErrorMessage = "You Must Enter an Email")]
        public string email { get; set; }



        [Range(1,10000000,ErrorMessage = "You Must Enter a Category")]
        public int CategoryID { get; set; }
        public Category category { get; set; }



        public DateTime dateAdded { get; set; }
        public string organization { get; set; }

        public string Slug => firstName?.Replace(' ', '-').ToLower() + '-' + lastName?.Replace(' ', '-').ToLower();

    }
}
