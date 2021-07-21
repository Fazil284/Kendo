using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KendoTask.Models
{
    public class EmpClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }
        //[DataType(DataType.Date)]
        public string Dob { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
    }
}
