using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Code_First.Models
{
    public class commoncontext:DbContext
    {
        public DbSet <customer> customers { get; set; }
        public DbSet <Product> products { get; set; }
    }
}