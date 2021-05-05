namespace StudentRatingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Points",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Subject = c.String(),
                        Credits = c.Int(nullable: false),
                        Hours = c.Int(nullable: false),
                        Mark = c.Int(nullable: false),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Group = c.Int(nullable: false),
                        Specialty = c.Int(nullable: false),
                        ExtraPoint = c.Single(nullable: false),
                        RatingPoint = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Points", "Student_Id", "dbo.Students");
            DropIndex("dbo.Points", new[] { "Student_Id" });
            DropTable("dbo.Students");
            DropTable("dbo.Points");
        }
    }
}
