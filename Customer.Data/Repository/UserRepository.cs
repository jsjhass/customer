using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Customer.Data.Repository
{
    public class UserRepository
    {
        private CustomerContext db = new CustomerContext();
        public bool LoginUser(UserDetail ud)
        {
            var u = (from m in db.UserDetails where m.UserName == ud.UserName && m.Password == ud.Password select m).FirstOrDefault();
            if(u!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
