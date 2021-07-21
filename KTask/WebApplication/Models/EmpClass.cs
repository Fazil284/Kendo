using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class EmpClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
    }
}
