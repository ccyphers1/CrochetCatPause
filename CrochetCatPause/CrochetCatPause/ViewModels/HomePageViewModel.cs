using CrochetCatPause.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrochetCatPause.ViewModels
{
    public class HomePageViewModel
    {
        public IEnumerable<BlogPost> BlogPosts;
        public IEnumerable<UpcomingShow> UpcomingShows;
    }
}