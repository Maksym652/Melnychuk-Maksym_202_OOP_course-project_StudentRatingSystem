namespace StudentRatingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingCreditsType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Points", "Credits", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Points", "Credits", c => c.Int(nullable: false));
        }
    }
}
