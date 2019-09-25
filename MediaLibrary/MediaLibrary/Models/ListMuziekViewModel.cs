using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Models
{
    public class ListMuziekViewModel
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Artiest { get; set; }
        public bool Hidden { get; set; }
        public string Status { get; set; }
        public byte[] Foto { get; set; }
    }
}
