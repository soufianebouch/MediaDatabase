using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Domain
{
    public class Muziek
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Titel { get; set; }
        public string Artiest { get; set; }
        public byte[] Foto { get; set; }
        public bool Hidden { get; set; }
        public ICollection<RatingMuziek> Ratings { get; set; }
        public ICollection<UserMuziekGeluisterdStatus> UserMuziekGeluisterdStatuses { get; set; }
        public ICollection<UserMuziekAfspeellijst> MuziekUserAfspeelLijst { get; set; }

    }
}
