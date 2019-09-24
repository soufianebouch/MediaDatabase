using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MediaLibrary.Data;
using MediaLibrary.Domain;
using MediaLibrary.Models;
using MediaLibrary.Models.DeleteMedia;
using MediaLibrary.Models.DetailMedia;
using MediaLibrary.Models.EditMedia;
using MediaLibrary.Models.ReviewMedia;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
                    Id = item.Id,
                    Hidden = item.Hidden
                });
            }

            return View(movies);
        }
        [Authorize]
        public IActionResult FilmDelete(int id)
        {
            Film filmFromDb = _DbContext.Films.FirstOrDefault(a => a.Id == id);
            DeleteFilmViewModel film = new DeleteFilmViewModel();
            film.Titel = filmFromDb.Titel;
            film.Id = filmFromDb.Id;
            return View(film);
        }
        [HttpPost]
        [Authorize]
        public IActionResult FilmConfirmDelete(int id)
        {
            Film project = _DbContext.Films.FirstOrDefault(a => a.Id == id);
            _DbContext.Films.Remove(project);
            _DbContext.SaveChanges();
            if (User.IsInRole("Admin"))
            {
                return RedirectToAction("FilmsList");
            }
            else
            {
                return RedirectToAction("FilmsList", "Gebruiker");
            }
        }
        [Authorize]
        public IActionResult FilmEdit(int id)
        {
            Film filmFromDb = _DbContext.Films.FirstOrDefault(a => a.Id == id);
            EditFilmViewModel film = new EditFilmViewModel();
            film.Titel = filmFromDb.Titel;
            film.Regisseur = filmFromDb.Regisseur;
            film.Id = filmFromDb.Id;
            film.Hidden = filmFromDb.Hidden;
            film.BestaandeFoto = filmFromDb.Foto;

            return View(film);
        }
        [HttpPost]
        [Authorize]
        public IActionResult FilmEdit(EditFilmViewModel model, int id)
        {
            Film filmFromDb = _DbContext.Films.FirstOrDefault(a => a.Id == id);
            if (!TryValidateModel(model))
            {
                return View(model);
            }
            if (model.Foto != null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    model.Foto.CopyTo(stream);
                    filmFromDb.Foto = stream.ToArray();
                }
            }
            filmFromDb.Titel = model.Titel;
            filmFromDb.Regisseur = model.Regisseur;
            filmFromDb.Hidden = model.Hidden;
            _DbContext.SaveChanges();

            if (User.IsInRole("Admin"))
            {
                return RedirectToAction("FilmsList");
            }
            else
            {
                return RedirectToAction("FilmsList", "Gebruiker");
            }
        }
        [Authorize]
        public IActionResult FilmReview()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public IActionResult FilmReview(int id, FilmReviewModel model)
        {
            if (!TryValidateModel(model))
            {
                return View(model);
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //OPZOEKEN OF PERSOON AL RATING HEEFT
            var bestaandeRating = _DbContext.RatingFilms.FirstOrDefault(a => a.FilmId == id && a.UserId == userId);
            if (bestaandeRating != null)
            {
                _DbContext.RatingFilms.Remove(bestaandeRating);
            }
            //

            RatingFilm rating = new RatingFilm();
            Film film = _DbContext.Films.FirstOrDefault(a => a.Id == id);

            rating.UserId = userId;
            rating.Review = model.Review;
            rating.Score = model.Score;
            rating.FilmId = film.Id;

            _DbContext.RatingFilms.Add(rating);
            _DbContext.SaveChanges();

            if (User.IsInRole("Admin"))
            {
                return RedirectToAction("FilmsList");
            }
            else
            {
                return RedirectToAction("FilmsList", "Gebruiker");
            }
        }
        [Authorize]
        public IActionResult FilmGezien(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            GezienFilmViewModel model = new GezienFilmViewModel();

            IEnumerable<UserFilmGezienStatus> statusestest =
                _DbContext.UserFilmGezienStatuses
                .Include(a => a.GezienStatus)
                .Where(a => a.UserId == userId).ToList();

            UserFilmGezienStatus userFilmGezienStatus = statusestest.FirstOrDefault(x => x.FilmId == id);
            if (userFilmGezienStatus != null)
            {
                model.SelectedStatus = userFilmGezienStatus.GezienStatus.Naam;
            }

            List<GezienStatus> statusesFromDb = new List<GezienStatus>();

            foreach (var item in _DbContext.GezienStatusen)
            {
                statusesFromDb.Add(item);
            }

            List<SelectListItem> statuses = new List<SelectListItem>();

            foreach (var item in statusesFromDb)
            {
                statuses.Add(new SelectListItem()
                {
                    Text = item.Naam,
                    Value = item.Naam
                });
            }
            model.Statuses = statuses;

            return View(model);
        }
        [Authorize]
        [HttpPost]
        public IActionResult FilmGezien(int id, GezienFilmViewModel model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //STATUS VEWIJDEREN
            IEnumerable<UserFilmGezienStatus> statuses =
                _DbContext.UserFilmGezienStatuses
                .Include(a => a.GezienStatus)
                .Where(a => a.UserId == userId).ToList();

            UserFilmGezienStatus userFilmGezienStatus = statuses.FirstOrDefault(x => x.FilmId == id);
            if (userFilmGezienStatus != null)
            {
                _DbContext.UserFilmGezienStatuses.Remove(userFilmGezienStatus);
                _DbContext.SaveChanges();
            }
            //
            UserFilmGezienStatus newUserFilmGezienStatus = new UserFilmGezienStatus();

            GezienStatus status = _DbContext.GezienStatusen.FirstOrDefault(a => a.Naam == model.SelectedStatus);

            newUserFilmGezienStatus.UserId = userId;
            newUserFilmGezienStatus.FilmId = id;
            newUserFilmGezienStatus.GezienStatusId = status.Id;

            _DbContext.UserFilmGezienStatuses.Add(newUserFilmGezienStatus);
            _DbContext.SaveChanges();
            if (User.IsInRole("Admin"))
            {
                return RedirectToAction("FilmsList");
            }
            else
            {
                return RedirectToAction("FilmsList", "Gebruiker");
            }
        }

        public IActionResult FilmDetail(int id)
        {
            //ALLE STATUSSEN VAN 1 FILM
            IEnumerable<UserFilmGezienStatus> statuses =
                _DbContext.UserFilmGezienStatuses
                .Include(userFilmGezienStatus => userFilmGezienStatus.GezienStatus)
                .Where(userFilmGezienStatus => userFilmGezienStatus.FilmId == id).ToList();
            //
            int gezien = 0;
            int wilZien = 0;

            foreach (var status in statuses)
            {
                if (status.GezienStatus.Id == 3)
                {
                    wilZien++;
                }
                if (status.GezienStatus.Id == 2)
                {
                    gezien++;
                }
            }

            Film filmFromDb = _DbContext.Films.
                Include(a => a.Ratings).
                FirstOrDefault(a => a.Id == id);

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            //VOOR REVIEW VAN 1 GEBRUIKER TE ZIEN
            //var review = filmFromDb.Ratings.FirstOrDefault(a => a.FilmId == filmFromDb.Id && a.UserId == userId);
            //
            List<string> reviews = new List<string>();
            List<int> scores = new List<int>();

            var review = filmFromDb.Ratings.Where(a => a.FilmId == filmFromDb.Id).ToList();

            foreach (var item in review)
            {
                reviews.Add(item.Review);
                scores.Add(item.Score);
            }

            FilmDetailViewModel film = new FilmDetailViewModel()
            {
                Titel = filmFromDb.Titel,
                Regisseur = filmFromDb.Regisseur,
                Reviews = reviews,
                Scores = scores,
                Foto = filmFromDb.Foto,
                Gezien = gezien,
                WillenZien = wilZien
            };

            return View(film);
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
                    Id = item.Id,
                    Hidden = item.Hidden

                });
            }

            return View(podcasts);
        }
        [Authorize]
        public IActionResult PodcastDelete(int id)
        {
            Podcast podcastFromDb = _DbContext.Podcasts.FirstOrDefault(a => a.Id == id);
            DeletePodcastViewModel podcast = new DeletePodcastViewModel();
            podcast.Titel = podcastFromDb.Titel;
            podcast.Id = podcastFromDb.Id;
            return View(podcast);
        }
        [HttpPost]
        [Authorize]
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
                    Id = item.Id,
                    Hidden = item.Hidden
                });
            }

            return View(muziek);
        }
        [Authorize]
        public IActionResult MuziekDelete(int id)
        {
            Muziek muziekFromDb = _DbContext.Muziek.FirstOrDefault(a => a.Id == id);
            DeleteMuziekViewModel muziek = new DeleteMuziekViewModel();
            muziek.Titel = muziekFromDb.Titel;
            muziek.Id = muziekFromDb.Id;
            return View(muziek);
        }
        [HttpPost]
        [Authorize]
        public IActionResult MuziekConfirmDelete(int id)
        {
            Muziek project = _DbContext.Muziek.FirstOrDefault(a => a.Id == id);
            _DbContext.Muziek.Remove(project);
            _DbContext.SaveChanges();
            return RedirectToAction("MuziekList");
        }
        [Authorize]
        public IActionResult MuziekEdit(int id)
        {
            Muziek muziekFromDb = _DbContext.Muziek.FirstOrDefault(a => a.Id == id);
            EditMuziekViewModel muziek = new EditMuziekViewModel();
            muziek.Titel = muziekFromDb.Titel;
            muziek.Artiest = muziekFromDb.Artiest;
            muziek.Id = muziekFromDb.Id;
            muziek.Hidden = muziekFromDb.Hidden;
            muziek.BestaandeFoto = muziekFromDb.Foto;

            return View(muziek);
        }
        [Authorize]
        [HttpPost]
        public IActionResult MuziekEdit(EditMuziekViewModel model, int id)
        {
            Muziek muziekFromDb = _DbContext.Muziek.FirstOrDefault(a => a.Id == id);
            if (!TryValidateModel(model))
            {
                return View(model);
            }
            if (model.Foto != null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    model.Foto.CopyTo(stream);
                    muziekFromDb.Foto = stream.ToArray();
                }
            }
            muziekFromDb.Titel = model.Titel;
            muziekFromDb.Artiest = model.Artiest;
            muziekFromDb.Hidden = model.Hidden;
            _DbContext.SaveChanges();

            return RedirectToAction("MuziekList");
        }
        [Authorize]
        public IActionResult MuziekReview()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public IActionResult MuziekReview(int id, FilmReviewModel model)
        {
            if (!TryValidateModel(model))
            {
                return View(model);
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //OPZOEKEN OF PERSOON AL RATING HEEFT
            var bestaandeRating = _DbContext.RatingMuziek.FirstOrDefault(a => a.MuziekId == id && a.UserId == userId);
            if (bestaandeRating != null)
            {
                _DbContext.RatingMuziek.Remove(bestaandeRating);
            }
            //

            RatingMuziek rating = new RatingMuziek();
            Muziek film = _DbContext.Muziek.FirstOrDefault(a => a.Id == id);

            rating.UserId = userId;
            rating.Review = model.Review;
            rating.Score = model.Score;
            rating.MuziekId = film.Id;

            _DbContext.RatingMuziek.Add(rating);
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
                    Seizoen = item.Seizoen,
                    Id = item.Id,
                    Hidden = item.Hidden

                });
            }

            return View(series);
        }
        [Authorize]
        public IActionResult SerieDelete(int id)
        {
            Serie serieFromDb = _DbContext.Series.FirstOrDefault(a => a.Id == id);
            DeleteSerieViewModel serie = new DeleteSerieViewModel();
            serie.Titel = serieFromDb.Titel;
            serie.Id = serieFromDb.Id;
            return View(serie);
        }
        [HttpPost]
        [Authorize]
        public IActionResult SerieConfirmDelete(int id)
        {
            Serie project = _DbContext.Series.FirstOrDefault(a => a.Id == id);
            _DbContext.Series.Remove(project);
            _DbContext.SaveChanges();
            return RedirectToAction("SeriesList");
        }


     
    }
}
