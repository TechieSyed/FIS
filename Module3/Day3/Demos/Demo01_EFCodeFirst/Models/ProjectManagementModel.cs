using System;
using System.Data.Entity;
using System.Linq;

namespace Demo01_EFCodeFirst.Models
{
    public class ProjectManagementModel : DbContext
    {
      
        public ProjectManagementModel()
            : base("name=ProjectManagementModel")
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
    }

   
}