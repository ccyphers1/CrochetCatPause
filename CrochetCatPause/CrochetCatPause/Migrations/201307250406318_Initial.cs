namespace CrochetCatPause.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogPosts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Author = c.String(),
                        PostTime = c.DateTime(nullable: false),
                        Content = c.String(),
                        Published = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UpcomingShows",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ShowDate = c.DateTime(nullable: false),
                        City = c.String(),
                        State = c.String(),
                        Venue = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UpcomingShows");
            DropTable("dbo.BlogPosts");
        }
    }
}
