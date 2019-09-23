using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Models.Afspeellijst
{
    public class FilmViewModel
    {
        public string Naam { get; set; }
        public int Id { get; set; }
        public bool Checked { get; set; }
    }
}
