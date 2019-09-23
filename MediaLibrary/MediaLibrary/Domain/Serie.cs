using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Domain
{
    public class Serie
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Titel { get; set; }
        public string Seizoen { get; set; }
        public int HoeveelAfl { get; set; }
        public byte[] Foto { get; set; }
        public bool Hidden { get; set; }
        public ICollection<RatingSerie> Ratings { get; set; }
        public ICollection<UserSerieGezienStatus> UserSerieGezienStatuses { get; set; }
        public ICollection<UserSerieAfspeelLijst> SerieUserAfspeelLijst { get; set; }

    }
}
