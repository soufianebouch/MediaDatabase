using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Models.ReviewMedia
{
    public class DeleteReviewViewModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int MediaId { get; set; }
    }
}
