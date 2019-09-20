using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Models
{
    public class CreatePodcastViewModel
    {
        public string Titel { get; set; }
        public int Lengte { get; set; }
        public IFormFile Foto { get; set; }
    }
}
