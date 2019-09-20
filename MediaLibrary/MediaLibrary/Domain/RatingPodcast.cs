using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Domain
{
    public class RatingPodcast
    {
        public Podcast  Podcast { get; set; }
        public int PodcastId { get; set; }
        public IdentityUser User { get; set; }
        public string UserId { get; set; }
        public string Review { get; set; }
        public int Score { get; set; }
    }
}
