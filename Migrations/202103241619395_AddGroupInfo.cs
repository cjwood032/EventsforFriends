namespace Events.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGroupInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shindigs", "InPersonOnly", c => c.Boolean(nullable: false));
            AddColumn("dbo.Shindigs", "GroupID", c => c.Long(nullable: false));
            CreateIndex("dbo.Shindigs", "GroupID");
            AddForeignKey("dbo.Shindigs", "GroupID", "dbo.Groups", "GroupID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shindigs", "GroupID", "dbo.Groups");
            DropIndex("dbo.Shindigs", new[] { "GroupID" });
            DropColumn("dbo.Shindigs", "GroupID");
            DropColumn("dbo.Shindigs", "InPersonOnly");
        }
    }
}
