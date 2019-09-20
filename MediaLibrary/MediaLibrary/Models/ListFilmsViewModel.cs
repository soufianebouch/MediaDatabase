using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Models
{
    public class ListFilmsViewModel
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Regisseur { get; set; }
        public byte[] Foto { get; set; }
    }
}
