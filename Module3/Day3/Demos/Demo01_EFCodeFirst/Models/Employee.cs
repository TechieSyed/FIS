using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Demo01_EFCodeFirst.Models
{
    
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfJoining { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }

        [ForeignKey("Dept")]
        public int DepartmentId { get; set; }
        public Department Dept { get; set; }

        public ICollection<EmployeeProject> EmployeeProjects { get; set; }

     
        public Address EmployeeAddress { get; set; }
    }
}