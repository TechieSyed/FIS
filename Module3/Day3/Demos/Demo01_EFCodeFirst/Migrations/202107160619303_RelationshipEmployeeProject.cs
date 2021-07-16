namespace Demo01_EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationshipEmployeeProject : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeProjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        ProjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.ClientProjects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.ProjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeProjects", "ProjectId", "dbo.ClientProjects");
            DropForeignKey("dbo.EmployeeProjects", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.EmployeeProjects", new[] { "ProjectId" });
            DropIndex("dbo.EmployeeProjects", new[] { "EmployeeId" });
            DropTable("dbo.EmployeeProjects");
        }
    }
}
