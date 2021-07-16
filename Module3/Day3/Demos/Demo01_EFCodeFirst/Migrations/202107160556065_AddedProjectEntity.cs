namespace Demo01_EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedProjectEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientProjects",
                c => new
                    {
                        ProjectCode = c.Int(nullable: false),
                        ProjectTitle = c.String(nullable: false, maxLength: 30),
                        Budget = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StartDate = c.DateTime(nullable: false, storeType: "date"),
                        EndDate = c.DateTime(storeType: "date"),
                        Description = c.String(nullable: false, maxLength: 500, unicode: false),
                        TeamSize = c.Int(nullable: false),
                        ContactPersonDetails = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectCode);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ClientProjects");
        }
    }
}
