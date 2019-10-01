using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Models.DetailMedia
{
    public class MuziekDetailViewModel
    {
        public string Titel { get; set; }
        public string Artiest { get; set; }
        public List<string> Reviews { get; set; }
        public List<int> Scores { get; set; }
        public int Gezien { get; set; }
        public int WillenZien { get; set; }
        public byte[] Foto { get; set; }
    }
}
