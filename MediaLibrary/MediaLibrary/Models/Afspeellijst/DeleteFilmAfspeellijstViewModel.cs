using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Models.Afspeellijst
{
    public class DeleteFilmAfspeellijstViewModel
    {
        public string Titel { get; set; }
        public int Id { get; set; }
        public int AfspeellijsId { get; set; }
    }
}
