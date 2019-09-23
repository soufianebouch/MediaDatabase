using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediaLibrary.Models;
using MediaLibrary.Data;
using MediaLibrary.Domain;
using System.IO;

namespace MediaLibrary.Controllers
{
    public class HomeController : Controller
    {
        public ApplicationDbContext _DbContext { get; set; }
        public HomeController(ApplicationDbContext ctx)
        {
            _DbContext = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult MediaCreate()
        {
            return View();
        }
        public IActionResult CreateFilm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateFilm(CreateFilmViewModel model)
        {
            Film checkfilm = _DbContext.Films.FirstOrDefault(a => a.Titel == model.Titel);
           
            if (!TryValidateModel(model) || checkfilm != null)
            {
                return View(model);
            }
            Film film = new Film();
            film.Regisseur = model.Regisseur;
            film.Titel = model.Titel;
            film.Hidden = model.Hidden;
            if (model.Foto != null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    model.Foto.CopyTo(stream);
                    film.Foto = stream.ToArray();
                }
            }

            _DbContext.Films.Add(film);
            _DbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult CreateSerie()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSerie(CreateSerieViewModel model)
        {
            Serie serie = new Serie();
            serie.HoeveelAfl = model.HoeveelAfl;
            serie.Seizoen = model.Seizoen;
            serie.Titel = model.Titel;
            if (model.Foto != null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    model.Foto.CopyTo(stream);
                    serie.Foto = stream.ToArray();
                }
            }

            _DbContext.Series.Add(serie);
            _DbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult CreateMuziek()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateMuziek(CreateMuziekViewModel model)
        {
            Muziek liedje = new Muziek();
            liedje.Artiest = model.Artiest;
            liedje.Titel = model.Titel;
            if (model.Foto != null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    model.Foto.CopyTo(stream);
                    liedje.Foto = stream.ToArray();
                }
            }
            _DbContext.Muziek.Add(liedje);
            _DbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult CreatePodcast()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePodcast(CreatePodcastViewModel model)
        {
            Podcast podcast = new Podcast();
            podcast.Lengte = model.Lengte;
            podcast.Titel = model.Titel;
            if (model.Foto != null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    model.Foto.CopyTo(stream);
                    podcast.Foto = stream.ToArray();
                }
            }
            _DbContext.Podcasts.Add(podcast);
            _DbContext.SaveChanges();

            return RedirectToAction("Index");
        }





        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
