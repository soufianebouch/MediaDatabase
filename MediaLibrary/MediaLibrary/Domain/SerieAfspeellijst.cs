using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Domain
{
    public class SerieAfspeellijst
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Titel { get; set; }
        public string Beschrijving { get; set; }
        public bool Privé { get; set; }
        public ICollection<UserSerieAfspeelLijst> UserSerieAfspeelLijsts { get; set; }
    }
}
