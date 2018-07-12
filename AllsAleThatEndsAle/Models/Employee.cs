using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace AllsAleThatEndsAle.Models
{
    public class Employee: Person
    {
        [DisplayName("Hire Date")]
        public DateTime HireDate { get; set; }
        [DisplayName("Name of Emergency Contact")]
        public string EmergencyCName { get; set; }
        [DisplayName("Emergency Contact Address")]
        public string EmergCStreetAddress { get; set; }
        [DisplayName("Emergency Contact Phone Number")]
        public int EmergCPhonNum { get; set; }

    }
}