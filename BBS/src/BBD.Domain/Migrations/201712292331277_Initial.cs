namespace BBS.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Role = c.Int(nullable: false),
                        Gender = c.Int(nullable: false),
                        Name = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genders", t => t.Gender, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role, cascadeDelete: true)
                .Index(t => t.Role)
                .Index(t => t.Gender);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Role", "dbo.Roles");
            DropForeignKey("dbo.Users", "Gender", "dbo.Genders");
            DropIndex("dbo.Users", new[] { "Gender" });
            DropIndex("dbo.Users", new[] { "Role" });
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Genders");
        }
    }
}
