using MediaLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Models.Afspeellijst
{
    public class CreateFilmAfspeellijst
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Beschrijving { get; set; }
        public bool Privé { get; set; }
        public List<FilmViewModel> Films { get; set; }
    }
}
