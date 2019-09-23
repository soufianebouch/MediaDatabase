using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Models
{
    public class ListPodcastsViewModel
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public int Lengte { get; set; }
        public bool Hidden { get; set; }

        public byte[] Foto { get; set; }
    }
}
