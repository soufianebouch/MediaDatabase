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
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        [Authorize]
        public IActionResult Afspeellijsten()
        {
            return View();
        }
        [Authorize]
        public IActionResult FilmsAfspeelLijsten(string searchString)
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

            //SEARCH
            ViewData["CurrentFilter"] = searchString;

            if (!String.IsNullOrEmpty(searchString))
            {
                Listafspeelijsts = Listafspeelijsts.Where(a => a.Titel.Contains(searchString)).ToList();
            }

            //List<SelectListItem> privacy = new List<SelectListItem>();
            //privacy.Add(new SelectListItem()
            //{
            //    Text = "Privé",
            //    Value = "Privé"
            //});
            //privacy.Add(new SelectListItem()
            //{
            //    Text = "Publiek",
            //    Value = "Publiek"
            //});
            //SEARCH

            foreach (var item in Listafspeelijsts)
            {
                model.Add(new ListFilmAfspeellijstViewModel
                {
                    Id = item.Id,
                    Titel = item.Titel,
                    Beschrijving = item.Beschrijving,
                    Privé = item.Privé
                    
                });
            }
            


            return View(model);
        }
        [Authorize]
        public IActionResult FilmsAfspeelLijstDelete(int id)
        {
            FilmAfspeellijst afspeellijstFromDb = _DbContext.FilmAfspeellijsts.FirstOrDefault(a => a.Id == id);
            DeleteFilmAfspeellijstViewModel film = new DeleteFilmAfspeellijstViewModel();
            film.Titel = afspeellijstFromDb.Titel;
            film.Id = afspeellijstFromDb.Id;
            return View(film);
        }
        [HttpPost]
        [Authorize]
        public IActionResult FilmAfspeellijstConfirmDelete(int id)
        {
            FilmAfspeellijst afspeellijstFromDb = _DbContext.FilmAfspeellijsts.FirstOrDefault(a => a.Id == id);
            _DbContext.FilmAfspeellijsts.Remove(afspeellijstFromDb);
            _DbContext.SaveChanges();

            return RedirectToAction("FilmsAfspeelLijsten");
        }
        [Authorize]
        public IActionResult FilmAfspeellijstDetail(int Id)
        {
            List<FilmAfspeellijstDetailViewModel> models = new List<FilmAfspeellijstDetailViewModel>();

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            FilmAfspeellijst afspeellijst = _DbContext.FilmAfspeellijsts.
                Include(a=>a.UserFilmAfspeelLijsts).
                ThenInclude(b=> b.Film).
                FirstOrDefault(a => a.Id == Id);
            foreach (var item in afspeellijst.UserFilmAfspeelLijsts)
            {
                models.Add(new FilmAfspeellijstDetailViewModel
                {
                    AfspeellijstId = Id,
                    Id=item.FilmId,
                    Titel=item.Film.Titel,
                    Regisseur = item.Film.Regisseur
                });
            }
            return View(models);
        }
        [Authorize]
        public IActionResult DeleteFilmInAfspeellijst(int Id, int AfspeellijstId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            UserFilmAfspeelLijst filmFromDb = _DbContext.UserFilmAfspeelLijsts.
                Include(a=>a.Film).
                FirstOrDefault(a => a.UserId == userId && a.FilmId == Id && a.AfspeelLijstId == AfspeellijstId);
            DeleteFilmAfspeellijstViewModel film = new DeleteFilmAfspeellijstViewModel();
            film.AfspeellijsId = AfspeellijstId;
            film.Titel = filmFromDb.Film.Titel;
            film.Id = filmFromDb.Film.Id;
            return View(film);
        }
        [HttpPost]
        [Authorize]
        public IActionResult ConfirmDeleteFilmInAfspeellijst(int Id, int AfspeellijsId )
        {
            int test = AfspeellijsId;
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            UserFilmAfspeelLijst filmFromDb = _DbContext.UserFilmAfspeelLijsts.
                Include(a => a.Film).
                FirstOrDefault(a => a.UserId == userId && a.FilmId == Id && a.AfspeelLijstId == AfspeellijsId);
            _DbContext.UserFilmAfspeelLijsts.Remove(filmFromDb);
            _DbContext.SaveChanges();


            return RedirectToAction("FilmAfspeellijstDetail", new { id = test });
        }
        public IActionResult MuziekList(int id)
        {
            List<ListMuziekViewModel> muziek = new List<ListMuziekViewModel>();

            IEnumerable<Muziek> projectsFromDb =
                _DbContext.Muziek;
            string status = "Niet geluisterd";
            //STATUS 1 GEBRUIKER 1 FILM
            //UserFilmGezienStatus userFilmGezienStatus = GetStatus(item.Id);
            //
            //if (userFilmGezienStatus != null)
            //{
            //    status = userFilmGezienStatus.GezienStatus.Naam;
            //}
            foreach (var item in projectsFromDb)
            {
                muziek.Add(new ListMuziekViewModel()
                {
                    Titel = item.Titel,
                    Artiest = item.Artiest,
                    Foto = item.Foto,
                    Id = item.Id,
                    Hidden = item.Hidden,
                    Status=status
                });
            }

            return View(muziek);
        }

        
    }
}
