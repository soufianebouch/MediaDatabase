using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Models
{
    public class ListSeriesViewModel
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Seizoen { get; set; }
        public int HoeveelAfl { get; set; }
        public byte[] Foto { get; set; }
    }
}
