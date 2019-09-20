using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Models
{
    public class CreateSerieViewModel
    {
        public string Titel { get; set; }
        public string Seizoen { get; set; }
        public int HoeveelAfl { get; set; }
        public IFormFile Foto { get; set; }
    }
}
