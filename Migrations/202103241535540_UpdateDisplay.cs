namespace Events.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDisplay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "PersonCount", c => c.Short(nullable: false));
            AlterColumn("dbo.Groups", "GroupName", c => c.String(nullable: false));
            CreateIndex("dbo.Participants", "UserID");
            AddForeignKey("dbo.Participants", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Participants", "UserID", "dbo.Users");
            DropIndex("dbo.Participants", new[] { "UserID" });
            AlterColumn("dbo.Groups", "GroupName", c => c.String());
            DropColumn("dbo.Users", "PersonCount");
        }
    }
}
