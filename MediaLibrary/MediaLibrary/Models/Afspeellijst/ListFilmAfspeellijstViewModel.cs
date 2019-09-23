using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Models.Afspeellijst
{
    public class ListFilmAfspeellijstViewModel
    {
        public string Titel { get; set; }
        public string Beschrijving { get; set; }
        public bool Privé { get; set; }
    }
}
