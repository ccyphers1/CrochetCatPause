using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrochetCatPause.Models
{
    public class CatEntities : DbContext
    {
        public CatEntities() : base("name=DefaultConnection") {}

        public DbSet<BlogPost> posts { get; set; }
        public DbSet<UpcomingShow> shows { get; set; }

    }
}