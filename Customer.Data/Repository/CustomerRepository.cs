using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Customer.Data.Repository
{
    public class CustomerRepository
    {
        private CustomerContext db = new CustomerContext();
        public IEnumerable<CustomerDetail> GetData()
        { 
            var c=db.CustomerDetails;
            return c;
        }
        public CustomerDetail SelectDataById(int id)
        {
            var c=db.CustomerDetails.Find(id);
            return c;
        }
        public void InsertData(CustomerDetail cu)
        {
            db.CustomerDetails.Add(cu);
        }
        public void UpdateData(CustomerDetail cu)
        {
            db.CustomerDetails.Update(cu);
        }
        public void DeleteData(int id)
        {
            CustomerDetail cu = db.CustomerDetails.Find(id);
            db.CustomerDetails.Remove(cu);
        }
        public void SaveData()
        {
            db.SaveChanges();
        }
    }
}
