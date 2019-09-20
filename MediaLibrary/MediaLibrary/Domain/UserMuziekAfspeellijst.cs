using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Domain
{
    public class UserMuziekAfspeellijst
    {
        public IdentityUser User { get; set; }
        public string UserId { get; set; }
        public MuziekAfspeelLijst MuziekAfspeellijst { get; set; }
        public int MuziekAfspeelLijstId { get; set; }
        public Muziek Muziek { get; set; }
        public int MuziekId { get; set; }
    }
}
