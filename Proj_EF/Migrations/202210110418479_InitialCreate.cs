namespace Proj_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Name);
            
            CreateTable(
                "dbo.Telephones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mobile = c.String(),
                        Landline = c.String(),
                        Name_Name = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Name_Name)
                .Index(t => t.Name_Name);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Telephones", "Name_Name", "dbo.People");
            DropIndex("dbo.Telephones", new[] { "Name_Name" });
            DropTable("dbo.Telephones");
            DropTable("dbo.People");
        }
    }
}
