using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Customer.Data.Repository
{
    public class CustomerRepository:ICustomerRepository
    {
        private CustomerContext context;
        private DbSet<CustomerDetail> db;
        public CustomerRepository(CustomerContext context)
        {
            this.context = context;
            db = context.Set<CustomerDetail>();
        }
        public IEnumerable<CustomerDetail> GetData()
        { 
            var c=context.CustomerDetails;
            return c;
        }
        public CustomerDetail SelectDataById(int id)
        {
            var c=context.CustomerDetails.Find(id);
            return c;
        }
        public void InsertData(CustomerDetail cu)
        {
            context.CustomerDetails.Add(cu);
        }
        public void UpdateData(CustomerDetail cu)
        {
            context.CustomerDetails.Update(cu);
        }
        public void DeleteData(int id)
        {
            CustomerDetail cu = context.CustomerDetails.Find(id);
            context.CustomerDetails.Remove(cu);
        }
        public void SaveData()
        {
            context.SaveChanges();
        }
    }
}
