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
        public CustomerContext(DbContextOptions<CustomerContext> options):base(options)
        {

        }
        public DbSet<CustomerDetail> CustomerDetails { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
    }
}
