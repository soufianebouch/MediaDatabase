using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Domain
{
    public class GeluisterdStatus
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public ICollection<UserMuziekGeluisterdStatus> UserMuziekGeluisterdStatuses { get; set; }
        public ICollection<UserPodcastGeluisterdStatus> UserPodcastGeluisterdStatuses { get; set; }
    }
}
