namespace StudentRatingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddExamType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Points", "FinalExamType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Points", "FinalExamType");
        }
    }
}
