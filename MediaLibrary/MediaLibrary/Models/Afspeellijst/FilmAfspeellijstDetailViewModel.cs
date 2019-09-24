using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Models.Afspeellijst
{
    public class FilmAfspeellijstDetailViewModel
    {
        public int Id { get; set; }
        public int AfspeellijstId { get; set; }
        public string Titel { get; set; }
        public string Regisseur { get; set; }
    }
}
