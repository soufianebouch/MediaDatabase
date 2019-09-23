using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Models.EditMedia
{
    public class EditFilmViewModel
    {
        [Required(ErrorMessage = "Titel is verplicht")]
        public string Titel { get; set; }
        public int Id { get; set; }
        public string Regisseur { get; set; }
        public bool Hidden { get; set; }
        public byte[] BestaandeFoto { get; set; }
        public IFormFile Foto { get; set; }
    }
}
