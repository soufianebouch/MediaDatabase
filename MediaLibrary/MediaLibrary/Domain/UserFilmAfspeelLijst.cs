using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Domain
{
    public class UserFilmAfspeelLijst
    {
        public IdentityUser User { get; set; }
        public string UserId { get; set; }
        public FilmAfspeellijst Afspeellijst { get; set; }
        public int AfspeelLijstId { get; set; }
        public Film Film { get; set; }
        public int FilmId { get; set; }
    }
}
