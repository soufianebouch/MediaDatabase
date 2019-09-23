using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Domain
{
    public class Film
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Titel { get; set; }
        public string Regisseur { get; set; }
        public byte[] Foto { get; set; }
        public bool Hidden { get; set; }
        public ICollection<RatingFilm> Ratings { get; set; }
        public ICollection<UserFilmGezienStatus> UserFilmGezienStatuses { get; set; }
        public ICollection<UserFilmAfspeelLijst> FilmUserAfspeelLijst { get; set; }
    }
}
