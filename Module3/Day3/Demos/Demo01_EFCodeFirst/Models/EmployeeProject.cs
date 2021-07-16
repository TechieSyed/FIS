using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Demo01_EFCodeFirst.Models
{
    public class EmployeeProject
    {
        public int Id { get; set; }

        [ForeignKey("Emp")]
        public int EmployeeId { get; set; }
        public Employee Emp { get; set; }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}