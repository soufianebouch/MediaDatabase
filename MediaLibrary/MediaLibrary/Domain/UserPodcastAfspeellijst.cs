using Microsoft.AspNetCore.Identity;

namespace MediaLibrary.Domain
{
    public class UserPodcastAfspeellijst
    {
        public IdentityUser User { get; set; }
        public string UserId { get; set; }
        public PodcastAfspeellijst PodcastAfspeellijst { get; set; }
        public int PodcastAfspeellijstId { get; set; }
        public Podcast Podcast { get; set; }
        public int PodcastId { get; set; }
    }
}