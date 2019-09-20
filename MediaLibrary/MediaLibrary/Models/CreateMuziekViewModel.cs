using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Models
{
    public class CreateMuziekViewModel
    {
        public string Titel { get; set; }
        public string Artiest { get; set; }
        public IFormFile Foto { get; set; }

    }
}
