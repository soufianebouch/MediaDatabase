using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Models.EditMedia
{
    public class EditMuziekViewModel
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Titel { get; set; }
        public string Artiest { get; set; }
        public byte[] BestaandeFoto { get; set; }
        public IFormFile Foto { get; set; }
        public bool Hidden { get; set; }
    }
}
