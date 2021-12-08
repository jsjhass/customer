using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Customer.Data.Models
{
    public class CustomerContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlServer("Server=ASUS; Initial Catalog=Customer; Integrated Security=true;");
        }
        public DbSet<CustomerDetail> CustomerDetails { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
    }
}