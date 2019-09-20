using Microsoft.AspNetCore.Identity;

namespace MediaLibrary.Domain
{
    public class UserSerieAfspeelLijst
    {
        public IdentityUser User { get; set; }
        public string UserId { get; set; }
        public SerieAfspeellijst SerieAfspeellijst { get; set; }
        public int SerieAfspeellijstId { get; set; }
        public Serie Serie { get; set; }
        public int SerieId { get; set; }
    }
}