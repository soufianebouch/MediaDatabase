using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Domain
{
    public class GezienStatus
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public ICollection<UserFilmGezienStatus> UserFilmGezienStatuses { get; set; }
        public ICollection<UserSerieGezienStatus> UserSerieGezienStatuses { get; set; }

    }
}
