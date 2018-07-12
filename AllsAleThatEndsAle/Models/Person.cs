using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AllsAleThatEndsAle.Models
{
    public abstract class Person
    {
        [Key]
        public int PersonID { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }
        
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
       

        

        
    }
}