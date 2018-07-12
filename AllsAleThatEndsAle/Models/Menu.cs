using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AllsAleThatEndsAle.Models
{
    public class Menu
    {
        [Key]
        public int MenuID { get; set; }
        public string MenuItem { get; set; }
        public double ItemPrice { get; set; }
    }
}