using MediaLibrary.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Models.ReviewMedia
{
    public class GezienFilmViewModel
    {
        public string SelectedStatus { get; set; }
        public List<SelectListItem> Statuses { get; set; }
        public GezienStatus GezienStatus { get; set; }
        public int GezienStatusId { get; set; }
    }
}
