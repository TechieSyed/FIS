﻿namespace Demo01_EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DepartmentEmployeeRelationship : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "DepartmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "DepartmentId");
            AddForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments", "DepartmentId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "DepartmentId" });
            DropColumn("dbo.Employees", "DepartmentId");
        }
    }
}
