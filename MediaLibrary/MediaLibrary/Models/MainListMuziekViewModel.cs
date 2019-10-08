using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Models
{
    public class MainListMuziekViewModel
    {
        public List<ListMuziekViewModel> Songs { get; set; }
        public string SelectedStatus { get; set; }
        public List<SelectListItem> Statuses { get; set; }
    }
}
