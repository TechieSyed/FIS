namespace Demo01_EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEmployeeAddress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "EmployeeAddress_AddressLine1", c => c.String());
            AddColumn("dbo.Employees", "EmployeeAddress_AddressLine2", c => c.String());
            AddColumn("dbo.Employees", "EmployeeAddress_City", c => c.String());
            AddColumn("dbo.Employees", "EmployeeAddress_State", c => c.String());
            AddColumn("dbo.Employees", "EmployeeAddress_Country", c => c.String());
            AddColumn("dbo.Employees", "EmployeeAddress_PostalCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "EmployeeAddress_PostalCode");
            DropColumn("dbo.Employees", "EmployeeAddress_Country");
            DropColumn("dbo.Employees", "EmployeeAddress_State");
            DropColumn("dbo.Employees", "EmployeeAddress_City");
            DropColumn("dbo.Employees", "EmployeeAddress_AddressLine2");
            DropColumn("dbo.Employees", "EmployeeAddress_AddressLine1");
        }
    }
}
