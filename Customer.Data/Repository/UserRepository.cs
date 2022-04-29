using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Customer.Data.Repository
{
    public class UserRepository:IUserRepository
    {
        private CustomerContext context;
        private DbSet<UserDetail> db;
        public UserRepository(CustomerContext context)
        {
            this.context = context;
            db = context.Set<UserDetail>();
        }
        public bool LoginUser(UserDetail ud)
        {
            var u = (from m in context.UserDetails where m.UserName == ud.UserName && m.Password == ud.Password select m).FirstOrDefault();
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
