using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Models
{
    public class CreateFilmViewModel
    {
        [Required(ErrorMessage = "Titel is verplicht")]
        public string Titel { get; set; }
        public string Regisseur { get; set; }
        public bool Hidden { get; set; }
        public IFormFile Foto { get; set; }
    }
}
