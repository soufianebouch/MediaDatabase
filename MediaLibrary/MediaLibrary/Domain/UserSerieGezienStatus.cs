using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Domain
{
    public class UserSerieGezienStatus
    {
        public int SerieId { get; set; }
        public Serie Serie { get; set; }
        public IdentityUser User { get; set; }
        public string UserId { get; set; }
        public GezienStatus GezienStatus { get; set; }
        public int GezienStatusId { get; set; }
    }
}
