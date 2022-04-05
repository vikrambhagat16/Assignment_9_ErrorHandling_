using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_10_ErrorHandling. Models
{
    public class Employee
    {
        [Required]
        public int EmpId { get; set; }
        [Required]
        public string EmpName { get; set; }
        [Required]
        [EmailAddress]
        public string EmailId { get; set; }
        [Required]
        //[MinLength(2),MaxLength(10)]
        public int MobileNumber { get; set; }
        public string Address { get; set; }
    }
}
