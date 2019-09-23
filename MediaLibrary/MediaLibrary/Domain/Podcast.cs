using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Domain
{
    public class Podcast
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Titel { get; set; }
        public int Lengte { get; set; }
        public byte[] Foto { get; set; }
        public bool Hidden { get; set; }
        public ICollection<RatingPodcast> Ratings { get; set; }
        public ICollection<UserPodcastGeluisterdStatus> UserPodcastGeluisterdStatuses { get; set; }
        public ICollection<UserPodcastAfspeellijst> PodcastUserAfspeelLijst { get; set; }

    }
}
