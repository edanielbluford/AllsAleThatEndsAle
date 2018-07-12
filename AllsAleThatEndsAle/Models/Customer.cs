using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace AllsAleThatEndsAle.Models
{
    public class Customer: Person
    {
        [DisplayName("LargestBill")]
        public double MaxBill { get; set; }

        [DisplayName("Favorite Meal")]
        public string FavMeal { get; set; }
        [DisplayName("Favorite Drink")]
        public string FavDrink { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }

    }
}