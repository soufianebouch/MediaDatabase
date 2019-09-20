using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Domain
{
    public class UserFilmGezienStatus
    {
        public int FilmId { get; set; }
        public Film Film { get; set; }
        public IdentityUser User { get; set; }
        public string UserId { get; set; }
        public GezienStatus GezienStatus { get; set; }
        public int GezienStatusId { get; set; }
    }
}
