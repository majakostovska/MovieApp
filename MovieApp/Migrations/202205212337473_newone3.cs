namespace MovieApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newone3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.People", "Role_Id", "dbo.Roles");
            DropIndex("dbo.People", new[] { "Role_Id" });
            DropColumn("dbo.People", "Role_Id");
            DropTable("dbo.Roles");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.People", "Role_Id", c => c.Int());
            CreateIndex("dbo.People", "Role_Id");
            AddForeignKey("dbo.People", "Role_Id", "dbo.Roles", "Id");
        }
    }
}
