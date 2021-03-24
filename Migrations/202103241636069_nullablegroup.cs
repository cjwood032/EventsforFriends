namespace Events.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullablegroup : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Shindigs", "GroupID", "dbo.Groups");
            DropIndex("dbo.Shindigs", new[] { "GroupID" });
            AlterColumn("dbo.Shindigs", "GroupID", c => c.Long());
            CreateIndex("dbo.Shindigs", "GroupID");
            AddForeignKey("dbo.Shindigs", "GroupID", "dbo.Groups", "GroupID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shindigs", "GroupID", "dbo.Groups");
            DropIndex("dbo.Shindigs", new[] { "GroupID" });
            AlterColumn("dbo.Shindigs", "GroupID", c => c.Long(nullable: false));
            CreateIndex("dbo.Shindigs", "GroupID");
            AddForeignKey("dbo.Shindigs", "GroupID", "dbo.Groups", "GroupID", cascadeDelete: true);
        }
    }
}
