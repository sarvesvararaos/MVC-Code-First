using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace MVC_Code_First.Models
{
    public class customer
    {
        public int id { get; set; }
        public string cname { get; set; }
        public string csal { get; set; }
        public int Productid { get; set; }
        public virtual  Product product { get; set; }
    }
}