using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer.Data.Models;

namespace Customer.Data.Repository
{
    public interface ICustomerRepository
    {
        public IEnumerable<CustomerDetail> GetData();
        public CustomerDetail SelectDataById(int id);
        public void InsertData(CustomerDetail cu);
        public void UpdateData(CustomerDetail cu);
        public void DeleteData(int id);
        public void SaveData();
    }
}
