namespace CrochetCatPause.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BlogPosts", "Title", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.BlogPosts", "Author", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.BlogPosts", "Content", c => c.String(nullable: false));
            AlterColumn("dbo.UpcomingShows", "City", c => c.String(nullable: false));
            AlterColumn("dbo.UpcomingShows", "State", c => c.String(nullable: false, maxLength: 2));
            AlterColumn("dbo.UpcomingShows", "Venue", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UpcomingShows", "Venue", c => c.String());
            AlterColumn("dbo.UpcomingShows", "State", c => c.String());
            AlterColumn("dbo.UpcomingShows", "City", c => c.String());
            AlterColumn("dbo.BlogPosts", "Content", c => c.String());
            AlterColumn("dbo.BlogPosts", "Author", c => c.String());
            AlterColumn("dbo.BlogPosts", "Title", c => c.String());
        }
    }
}
