using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer.Data.Models;

namespace Customer.Data.Repository
{
    public interface IUserRepository
    {
        public bool LoginUser(UserDetail ud);
    }
}
