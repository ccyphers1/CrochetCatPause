namespace CrochetCatPause.Migrations
{
    using CrochetCatPause.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CrochetCatPause.Models.CatEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CrochetCatPause.Models.CatEntities context)
        {
            context.posts.AddOrUpdate(p => p.Title,
                new BlogPost
                {
                    Title = "First Test Post",
                    Author = "Chance",
                    PostTime = DateTime.Today,
                    Content = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem",
                    Published = true
                },
                new BlogPost
                {
                    Title = "Second Test Post",
                    Author = "Chance",
                    PostTime = DateTime.Today,
                    Content = "minima veniam, molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et haquis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure repre",
                    Published = true
                }
                );

            context.shows.AddOrUpdate(s => s.Venue,
                new UpcomingShow
                {
                    ShowDate = DateTime.Parse("11/11/2011"),
                    City =  "Detroit",
                    State = "MI",
                    Venue = "Some Venue"
                },

                new UpcomingShow
                {
                    ShowDate = DateTime.Parse("6/6/2006"),
                    City = "Some City",
                    State = "MI",
                    Venue = "00 Pub"
                }
                );

            
        }
    }
}
