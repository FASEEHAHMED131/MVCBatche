using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Batch201910B_10B1_10C.Models
{
    public class Context_Batch201910B_10B1_10C : DbContext
    {
        public Context_Batch201910B_10B1_10C() : base("Context_Batch201910B_10B1_10C")
        {

        }
        public DbSet<Employee> employees { get; set; }
        public DbSet<ContactForm> form { get; set; }
    }
}