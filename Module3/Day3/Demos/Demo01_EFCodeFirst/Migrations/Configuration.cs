namespace Demo01_EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Demo01_EFCodeFirst.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Demo01_EFCodeFirst.Models.ProjectManagementModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Demo01_EFCodeFirst.Models.ProjectManagementModel context)
        {
            var d1 = new Department() { DepartmentName="IT" };
            var d2 = new Department() { DepartmentName="Research" };
            context.Departments.AddOrUpdate(d => d.DepartmentName, d1, d2);
        }
    }
}
