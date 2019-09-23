using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MediaLibrary.Data;
using MediaLibrary.Domain;
using MediaLibrary.Models;
using MediaLibrary.Models.Afspeellijst;
using MediaLibrary.Models.ReviewMedia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MediaLibrary.Controllers
{
    public class GebruikerController : Controller
    {
        public ApplicationDbContext _DbContext { get; set; }
        public GebruikerController(ApplicationDbContext ctx)
        {
            _DbContext = ctx;
        }
        public UserFilmGezienStatus GetStatus(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            GezienFilmViewModel model = new GezienFilmViewModel();

            IEnumerable<UserFilmGezienStatus> statusestest =
                _DbContext.UserFilmGezienStatuses
                .Include(a => a.GezienStatus)
                .Where(a => a.UserId == userId).ToList();

            UserFilmGezienStatus userFilmGezienStatus = statusestest.FirstOrDefault(x => x.FilmId == id);
            return userFilmGezienStatus;
        }
        // GET: /<controller>/
        public IActionResult Media()
        {
            return View();
        }
        public IActionResult FilmsList(int id)
        {
            List<ListFilmsViewModel> movies = new List<ListFilmsViewModel>();

            IEnumerable<Film> projectsFromDb =
                _DbContext.Films;

            foreach (var item in projectsFromDb)
            {
                string status = "Niet gezien";
                //STATUS 1 GEBRUIKER 1 FILM
                UserFilmGezienStatus userFilmGezienStatus = GetStatus(item.Id);
                //
                if (userFilmGezienStatus != null)
                {
                    status = userFilmGezienStatus.GezienStatus.Naam;
                }
                movies.Add(new ListFilmsViewModel()
                {
                    Titel = item.Titel,
                    Regisseur = item.Regisseur,
                    Foto = item.Foto,
                    Id = item.Id,
                    Hidden = item.Hidden,
                    Status = status
                });
            }

            return View(movies);
        }

        public IActionResult Afspeellijsten()
        {
            return View();
        }
        public IActionResult FilmsAfspeelLijsten()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            List<UserFilmAfspeelLijst> filmAfspeelLijsten = _DbContext.UserFilmAfspeelLijsts.Where(a => a.UserId == userId).ToList();
            var afspeelLijstSingle = filmAfspeelLijsten.GroupBy(x => x.AfspeelLijstId).Select(g => g.First()).ToList();
            List<FilmAfspeellijst> Listafspeelijsts = new List<FilmAfspeellijst>();
            foreach (var item in afspeelLijstSingle)
            {
                FilmAfspeellijst afspeellijst = _DbContext.FilmAfspeellijsts.FirstOrDefault(a => a.Id == item.AfspeelLijstId);
                Listafspeelijsts.Add(afspeellijst);
            }
            List<ListFilmAfspeellijstViewModel> model = new List<ListFilmAfspeellijstViewModel>();

            foreach (var item in Listafspeelijsts)
            {
                model.Add(new ListFilmAfspeellijstViewModel
                {
                    Titel = item.Titel,
                    Beschrijving = item.Beschrijving,
                    Privé = item.Privé
                });
            }

            return View(model);
        }
        
    }
}
