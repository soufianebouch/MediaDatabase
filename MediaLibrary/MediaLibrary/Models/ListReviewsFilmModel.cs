using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Models
{
    public class ListReviewsFilmModel
    {
        public string UserId { get; set; }
        public int MediaId { get; set; }
        public string MediaNaam { get; set; }
        public string UserNaam { get; set; }
        public string Review { get; set; }
        public int Score { get; set; }
    }
}
