using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Customer.Data.Models
{
    public class CustomerDetail
    {
        [Key]
        public int CustomerId { get; set; }
        [Required(ErrorMessage ="Customer Name is required")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage ="Customer City is required")]
        public string CustomerCity { get; set; }
        [Required(ErrorMessage ="Customer Email address is required")]
        [EmailAddress(ErrorMessage ="Please enter correct email addresss")]
        public string CustomerEmail { get; set; }
        [Required(ErrorMessage ="Customer Mobile number is required")]
        public string CustomerMobile { get; set; }
    }
}
