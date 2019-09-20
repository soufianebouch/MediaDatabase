using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaLibrary.Data;
using MediaLibrary.Domain;
using MediaLibrary.Models;
using MediaLibrary.Models.DeleteMedia;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MediaLibrary.Controllers
{
    public class AdminController : Controller
    {
        public ApplicationDbContext _DbContext { get; set; }
        public AdminController(ApplicationDbContext ctx)
        {
            _DbContext = ctx;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Media()
        {
            return View();
        }
        public IActionResult FilmsList()
        {
            List<ListFilmsViewModel> movies = new List<ListFilmsViewModel>();

            IEnumerable<Film> projectsFromDb =
                _DbContext.Films;

            foreach (var item in projectsFromDb)
            {
                movies.Add(new ListFilmsViewModel()
                {
                    Titel = item.Titel,
                    Regisseur = item.Regisseur,
                    Foto = item.Foto,
                    Id = item.Id
                });
            }

            return View(movies);
        }
        public IActionResult FilmDelete(int id)
        {
            Film filmFromDb = _DbContext.Films.FirstOrDefault(a => a.Id == id);
            DeleteFilmViewModel film = new DeleteFilmViewModel();
            film.Titel = filmFromDb.Titel;
            film.Id = filmFromDb.Id;
            return View(film);
        }
        [HttpPost]
        public IActionResult FilmConfirmDelete(int id)
        {
            Film project = _DbContext.Films.FirstOrDefault(a => a.Id == id);
            _DbContext.Films.Remove(project);
            _DbContext.SaveChanges();
            return RedirectToAction("FilmsList");
        }


        public IActionResult PodcastList()
        {
            List<ListPodcastsViewModel> podcasts = new List<ListPodcastsViewModel>();

            IEnumerable<Podcast> projectsFromDb =
                _DbContext.Podcasts;

            foreach (var item in projectsFromDb)
            {
                podcasts.Add(new ListPodcastsViewModel()
                {
                    Titel = item.Titel,
                    Lengte = item.Lengte,
                    Foto = item.Foto,
                    Id = item.Id
                });
            }

            return View(podcasts);
        }
        public IActionResult PodcastDelete(int id)
        {
            Podcast podcastFromDb = _DbContext.Podcasts.FirstOrDefault(a => a.Id == id);
            DeletePodcastViewModel podcast = new DeletePodcastViewModel();
            podcast.Titel = podcastFromDb.Titel;
            podcast.Id = podcastFromDb.Id;
            return View(podcast);
        }
        [HttpPost]
        public IActionResult PodcastConfirmDelete(int id)
        {
            Podcast project = _DbContext.Podcasts.FirstOrDefault(a => a.Id == id);
            _DbContext.Podcasts.Remove(project);
            _DbContext.SaveChanges();
            return RedirectToAction("PodcastList");
        }


        public IActionResult MuziekList()
        {
            List<ListMuziekViewModel> muziek = new List<ListMuziekViewModel>();

            IEnumerable<Muziek> projectsFromDb =
                _DbContext.Muziek;

            foreach (var item in projectsFromDb)
            {
                muziek.Add(new ListMuziekViewModel()
                {
                    Titel = item.Titel,
                    Artiest = item.Artiest,
                    Foto = item.Foto,
                    Id = item.Id
                });
            }

            return View(muziek);
        }
        public IActionResult MuziekDelete(int id)
        {
            Muziek muziekFromDb = _DbContext.Muziek.FirstOrDefault(a => a.Id == id);
            DeleteMuziekViewModel muziek = new DeleteMuziekViewModel();
            muziek.Titel = muziekFromDb.Titel;
            muziek.Id = muziekFromDb.Id;
            return View(muziek);
        }
        [HttpPost]
        public IActionResult MuziekConfirmDelete(int id)
        {
            Muziek project = _DbContext.Muziek.FirstOrDefault(a => a.Id == id);
            _DbContext.Muziek.Remove(project);
            _DbContext.SaveChanges();
            return RedirectToAction("MuziekList");
        }


        public IActionResult SeriesList()
        {
            List<ListSeriesViewModel> series = new List<ListSeriesViewModel>();

            IEnumerable<Serie> projectsFromDb =
                _DbContext.Series;

            foreach (var item in projectsFromDb)
            {
                series.Add(new ListSeriesViewModel()
                {
                    Titel = item.Titel,
                    HoeveelAfl = item.HoeveelAfl,
                    Foto = item.Foto,
                    Seizoen=item.Seizoen,
                    Id = item.Id
                });
            }

            return View(series);
        }
        public IActionResult SerieDelete(int id)
        {
            Serie serieFromDb = _DbContext.Series.FirstOrDefault(a => a.Id == id);
            DeleteSerieViewModel serie = new DeleteSerieViewModel();
            serie.Titel = serieFromDb.Titel;
            serie.Id = serieFromDb.Id;
            return View(serie);
        }
        public IActionResult SerieConfirmDelete(int id)
        {
            Serie project = _DbContext.Series.FirstOrDefault(a => a.Id == id);
            _DbContext.Series.Remove(project);
            _DbContext.SaveChanges();
            return RedirectToAction("SeriesList");
        }

        public IActionResult Afspeellijsten()
        {
            return View();
        }
        public IActionResult Gebruikers()
        {
            return View();
        }
    }
}
