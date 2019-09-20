using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Domain
{
    public class MuziekAfspeelLijst
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Titel { get; set; }
        public string Beschrijving { get; set; }
        public bool Privé { get; set; }

        public ICollection<UserMuziekAfspeellijst> UserMuziekAfspeellijst { get; set; }
    }
}
