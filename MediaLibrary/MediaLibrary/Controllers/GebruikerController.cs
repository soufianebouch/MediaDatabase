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
        public IActionResult FilmsList(string searchString)
        {
            List<ListFilmsViewModel> movies = new List<ListFilmsViewModel>();

            IEnumerable<Film> projectsFromDb =
                _DbContext.Films;

            if (!String.IsNullOrEmpty(searchString))
            {
                projectsFromDb = projectsFromDb.Where(a => a.Titel.Contains(searchString)).ToList();
                ViewData["currentFilter"] = searchString;
            }
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
        public IActionResult FilmAfspeellijstEdit(int id)
        {
            FilmAfspeellijst afspeellijstFromDb = _DbContext.FilmAfspeellijsts.
                Include(a=> a.UserFilmAfspeelLijsts).
                ThenInclude(b => b.Film).
                FirstOrDefault(a => a.Id == id);

            List<FilmViewModel> films = new List<FilmViewModel>();

            foreach (var item in _DbContext.Films)
            {
                if (afspeellijstFromDb.UserFilmAfspeelLijsts.FirstOrDefault(a=>a.FilmId == item.Id) != null)
                {
                    films.Add(new FilmViewModel()
                    {
                        Checked = true,
                        Naam = item.Titel,
                        Id = item.Id
                    });
                }
                else
                {
                    films.Add(new FilmViewModel()
                    {
                        Naam = item.Titel,
                        Id = item.Id
                    });
                }
            }
            CreateFilmAfspeellijst model = new CreateFilmAfspeellijst();

            model.Titel = afspeellijstFromDb.Titel;
            model.Beschrijving = afspeellijstFromDb.Beschrijving;
            model.Privé = afspeellijstFromDb.Privé;
            model.Id = afspeellijstFromDb.Id;
            model.Films = films;

            return View(model);
        }
        [HttpPost]
        [Authorize]
        public IActionResult FilmAfspeellijstEdit(int id, CreateFilmAfspeellijst model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            FilmAfspeellijst afspeellijst = _DbContext.FilmAfspeellijsts.FirstOrDefault(a => a.Id == id);
            afspeellijst.Titel = model.Titel;
            afspeellijst.Beschrijving = model.Beschrijving;
            afspeellijst.Privé = model.Privé;

            foreach (var item in model.Films)
            {
                if (item.Checked == true)
                {
                    UserFilmAfspeelLijst usf = new UserFilmAfspeelLijst
                    {
                        AfspeelLijstId = afspeellijst.Id,
                        FilmId = item.Id,
                        UserId = userId
                    };
                    if (_DbContext.UserFilmAfspeelLijsts.FirstOrDefault(a=> a.FilmId == item.Id && a.AfspeelLijstId == afspeellijst.Id && a.UserId == userId) == null)
                    {
                        _DbContext.UserFilmAfspeelLijsts.Add(usf);
                        afspeellijst.UserFilmAfspeelLijsts.Add(usf);
                    }
                }
                else
                {
                    UserFilmAfspeelLijst usf = new UserFilmAfspeelLijst
                    {
                        AfspeelLijstId = afspeellijst.Id,
                        FilmId = item.Id,
                        UserId = userId
                    };
                    var test = _DbContext.UserFilmAfspeelLijsts.FirstOrDefault(a => a.FilmId == item.Id && a.AfspeelLijstId == afspeellijst.Id && a.UserId == userId);
                    if (test != null)
                    {
                        afspeellijst.UserFilmAfspeelLijsts.Remove(test);
                        _DbContext.UserFilmAfspeelLijsts.Remove(test);
                    }
                }
            }
            _DbContext.SaveChanges();

            return RedirectToAction("FilmsAfspeelLijsten");
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
        public IActionResult FilmAfspeellijstDetail(int Id)
        {
            List<FilmAfspeellijstDetailViewModel> models = new List<FilmAfspeellijstDetailViewModel>();

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
        public IActionResult MuziekList(string searchString)
        {
            List<ListMuziekViewModel> muziek = new List<ListMuziekViewModel>();

            //STATUSSEN

            List<SelectListItem> statuses = new List<SelectListItem>();

            foreach (var item in _DbContext.GeluisterdStatuses)
            {
                statuses.Add(new SelectListItem()
                {
                    Text = item.Naam,
                    Value = item.Naam
                });
            }
            


            //STATUSSEN

            IEnumerable<Muziek> projectsFromDb =
                _DbContext.Muziek;

            if (!String.IsNullOrEmpty(searchString))
            {
                projectsFromDb = projectsFromDb.Where(a => a.Titel.Contains(searchString)).ToList();
                ViewData["currentFilter"] = searchString;
            }

            foreach (var item in projectsFromDb)
            {
                string status = "Niet geluisterd";

                if (User.Identity.IsAuthenticated)
                {
                    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                    UserMuziekGeluisterdStatus statusesFromDb =
                        _DbContext.userMuziekGeluisterdStatuses
                        .Include(a => a.GeluisterdStatus)
                        .FirstOrDefault(a => a.UserId == userId && a.MuziekId == item.Id);
                    if (statusesFromDb != null)
                    {
                    status = statusesFromDb.GeluisterdStatus.Naam;

                    }
                }
                muziek.Add(new ListMuziekViewModel()
                {
                    Titel = item.Titel,
                    Artiest = item.Artiest,
                    Foto = item.Foto,
                    Id = item.Id,
                    Hidden = item.Hidden,
                    SelectedStatus = status,
                    Statuses = statuses,
                });
            }

            return View(muziek);
        }
        public IActionResult PodcastList(string searchString)
        {
            List<ListPodcastsViewModel> muziek = new List<ListPodcastsViewModel>();

            IEnumerable<Podcast> projectsFromDb =
                _DbContext.Podcasts;
            string status = "Niet geluisterd";
            if (!String.IsNullOrEmpty(searchString))
            {
                projectsFromDb = projectsFromDb.Where(a => a.Titel.Contains(searchString)).ToList();
                ViewData["currentFilter"] = searchString;
            }

            foreach (var item in projectsFromDb)
            {
                muziek.Add(new ListPodcastsViewModel()
                {
                    Titel = item.Titel,
                    Lengte = item.Lengte,
                    Foto = item.Foto,
                    Status =status,
                    Id = item.Id
                });
            }

            return View(muziek);
        }

    }
}
