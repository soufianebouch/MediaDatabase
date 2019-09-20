using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Domain
{
    public class UserPodcastGeluisterdStatus
    {
        public int PodcastId { get; set; }
        public Podcast Podcast { get; set; }
        public IdentityUser User { get; set; }
        public string UserId { get; set; }
        public GeluisterdStatus GeluisterdStatus { get; set; }
        public int GeluisterdStatusId { get; set; }
    }
}
