using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Code_First.Models
{
    public class Product
    {
        public int Productid { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 5)]
        public string pname { get; set; }
        [Required]

        public string ploc { get; set; }

        public virtual ICollection<customer> custom { get; set; }
    }
}