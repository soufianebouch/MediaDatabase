using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaLibrary.Data;
using MediaLibrary.Domain;
using MediaLibrary.Models;
using MediaLibrary.Models.Afspeellijst;
using MediaLibrary.Models.ReviewMedia;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MediaLibrary.Controllers
{
    public class Admin2Controller : Controller
    {
        public ApplicationDbContext _DbContext { get; set; }
        public Admin2Controller(ApplicationDbContext ctx)
        {
            _DbContext = ctx;
        }
        // GET: /<controller>/
        [Authorize(Roles = "Admin")]
        public IActionResult Afspeellijsten()
        {
            return View();
        }
        public IActionResult FilmsAfspeelLijsten()
        {
            List<FilmAfspeellijst> Listafspeelijsts = _DbContext.FilmAfspeellijsts.ToList();
            
            List<ListFilmAfspeellijstViewModel> model = new List<ListFilmAfspeellijstViewModel>();

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
        [Authorize(Roles = "Admin")]
        public IActionResult FilmsAfspeelLijstDelete(int id)
        {
            FilmAfspeellijst afspeellijstFromDb = _DbContext.FilmAfspeellijsts.FirstOrDefault(a => a.Id == id);
            DeleteFilmAfspeellijstViewModel film = new DeleteFilmAfspeellijstViewModel();
            film.Titel = afspeellijstFromDb.Titel;
            film.Id = afspeellijstFromDb.Id;
            return View(film);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult FilmAfspeellijstConfirmDelete(int id)
        {
            FilmAfspeellijst afspeellijstFromDb = _DbContext.FilmAfspeellijsts.FirstOrDefault(a => a.Id == id);
            _DbContext.FilmAfspeellijsts.Remove(afspeellijstFromDb);
            _DbContext.SaveChanges();

            return RedirectToAction("FilmsAfspeelLijsten");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Gebruikers()
        {
            List<ListGebruikersViewModel> gebruikers = new List<ListGebruikersViewModel>();
            var users = _DbContext.Users.ToList();

            foreach (var item in users)
            {
                gebruikers.Add(new ListGebruikersViewModel
                {
                    Id=item.Id,
                    Username =item.UserName
                });
            }
            return View(gebruikers);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult GebruikerDelete(string Id)
        {
            var user = _DbContext.Users.FirstOrDefault(a=>a.Id == Id);
            ListGebruikersViewModel model = new ListGebruikersViewModel();
            model.Id = user.Id;
            model.Username = user.UserName;
            return View(model);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult GebruikerConfirmDelete(string Id)
        {
            var user = _DbContext.Users.FirstOrDefault(a => a.Id == Id);
            _DbContext.Users.Remove(user);
            _DbContext.SaveChanges();

            return RedirectToAction("Gebruikers");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Reviews()
        {
            List<ListReviewsFilmModel> reviews = new List<ListReviewsFilmModel>();
            var filmReviewsFromDb = _DbContext.RatingFilms.
                Include(a => a.Film).
                Include(a => a.User).
                ToList();
            var muziekReviewsFromDb = _DbContext.RatingMuziek.
                Include(a => a.Muziek).
                Include(a => a.User).
                ToList();
            var podcastReviewsFromDb = _DbContext.RatingPodcasts.
                Include(a => a.Podcast).
                Include(a => a.User).
                ToList();
            var serieReviewsFromDb = _DbContext.RatingSeries.
                Include(a => a.Serie).
                Include(a => a.User).
                ToList();
            foreach (var item in filmReviewsFromDb)
            {
                reviews.Add(new ListReviewsFilmModel
                {
                    MediaId=item.Film.Id,
                    UserId=item.UserId,
                    MediaNaam= item.Film.Titel,
                    UserNaam= item.User.UserName,
                    Review= item.Review,
                    Score=item.Score
                });
            }
            foreach (var item in muziekReviewsFromDb)
            {
                reviews.Add(new ListReviewsFilmModel
                {
                    MediaId = item.Muziek.Id,
                    UserId = item.UserId,
                    MediaNaam = item.Muziek.Titel,
                    UserNaam = item.User.UserName,
                    Review = item.Review,
                    Score = item.Score
                });
            }
            foreach (var item in podcastReviewsFromDb)
            {
                reviews.Add(new ListReviewsFilmModel
                {
                    MediaId = item.PodcastId,
                    UserId = item.UserId,
                    MediaNaam = item.Podcast.Titel,
                    UserNaam = item.User.UserName,
                    Review = item.Review,
                    Score = item.Score
                });
            }
            foreach (var item in serieReviewsFromDb)
            {
                reviews.Add(new ListReviewsFilmModel
                {
                    MediaId = item.Serie.Id,
                    UserId = item.UserId,
                    MediaNaam = item.Serie.Titel,
                    UserNaam = item.User.UserName,
                    Review = item.Review,
                    Score = item.Score
                });
            }

            return View(reviews);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult ReviewDelete( int MediaId, string UserId)
        {
            DeleteReviewViewModel reviewToDelete = new DeleteReviewViewModel();
            RatingFilm ratingFilm = _DbContext.RatingFilms.FirstOrDefault(a => a.FilmId == MediaId && a.UserId == UserId);
            RatingMuziek ratingMuziek = _DbContext.RatingMuziek.FirstOrDefault(a => a.MuziekId == MediaId && a.UserId == UserId);
            RatingSerie ratingSerie = _DbContext.RatingSeries.FirstOrDefault(a => a.SerieId == MediaId && a.UserId == UserId);
            RatingPodcast ratingPodcast = _DbContext.RatingPodcasts.FirstOrDefault(a => a.PodcastId == MediaId && a.UserId == UserId);
            if (ratingFilm != null)
            {
                reviewToDelete.MediaId = ratingFilm.FilmId;
                reviewToDelete.UserId = ratingFilm.UserId;
            }
            if (ratingMuziek != null)
            {
                reviewToDelete.MediaId = ratingMuziek.MuziekId;
                reviewToDelete.UserId = ratingMuziek.UserId;
            }
            if (ratingSerie != null)
            {
                reviewToDelete.MediaId = ratingSerie.SerieId;
                reviewToDelete.UserId = ratingSerie.UserId;
            }
            if (ratingPodcast != null)
            {
                reviewToDelete.MediaId = ratingPodcast.PodcastId;
                reviewToDelete.UserId = ratingPodcast.UserId;
            }

            return View(reviewToDelete);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult ReviewConfirmDelete(int id, string UserId)
        {
            RatingFilm ratingFilm = _DbContext.RatingFilms.FirstOrDefault(a => a.FilmId == id && a.UserId == UserId);
            RatingMuziek ratingMuziek = _DbContext.RatingMuziek.FirstOrDefault(a => a.MuziekId == id && a.UserId == UserId);
            RatingSerie ratingSerie = _DbContext.RatingSeries.FirstOrDefault(a => a.SerieId == id && a.UserId == UserId);
            RatingPodcast ratingPodcast = _DbContext.RatingPodcasts.FirstOrDefault(a => a.PodcastId == id && a.UserId == UserId);
            if (ratingFilm != null)
            {
                _DbContext.RatingFilms.Remove(ratingFilm);
                _DbContext.SaveChanges();
            }
            if (ratingMuziek != null)
            {
                _DbContext.RatingMuziek.Remove(ratingMuziek);
                _DbContext.SaveChanges();
            }
            if (ratingSerie != null)
            {
                _DbContext.RatingSeries.Remove(ratingSerie);
                _DbContext.SaveChanges();
            }
            if (ratingPodcast != null)
            {
                _DbContext.RatingPodcasts.Remove(ratingPodcast);
                _DbContext.SaveChanges();
            }
            return RedirectToAction("Reviews");
        }
    }
}
