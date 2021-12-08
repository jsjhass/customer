using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Customer.Data.Models
{
    public class UserDetail
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage="User Name is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
