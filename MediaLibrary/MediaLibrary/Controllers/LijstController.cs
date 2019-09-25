using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MediaLibrary.Data;
using MediaLibrary.Domain;
using MediaLibrary.Models.Afspeellijst;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MediaLibrary.Controllers
{
    public class LijstController : Controller
    {
        public ApplicationDbContext _DbContext { get; set; }
        public LijstController(ApplicationDbContext ctx)
        {
            _DbContext = ctx;
        }
        // GET: /<controller>/
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult CreateFilmAfspeellijst()
        {
            List<Film> filmsFromDb = new List<Film>();
            foreach (var item in _DbContext.Films)
            {
                filmsFromDb.Add(item);
            }

            List<FilmViewModel> films = new List<FilmViewModel>();
            foreach (var item in filmsFromDb)
            {
                films.Add(new FilmViewModel
                {
                    Naam = item.Titel,
                    Id = item.Id
                });
            }


            CreateFilmAfspeellijst model = new CreateFilmAfspeellijst();
            model.Films = films;
            //foreach (var item in _DbContext.Films)
            //{
            //    model.Films.Add(new FilmViewModel
            //    {
            //        Naam=item.Titel,
            //        Id=item.Id
            //    });
            //}
            return View(model);
        }
        [HttpPost]
        [Authorize]
        public IActionResult CreateFilmAfspeellijst(CreateFilmAfspeellijst model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            FilmAfspeellijst afspeellijst = new FilmAfspeellijst()
            {
                Titel=model.Titel,
                Beschrijving=model.Beschrijving,
                Privé=model.Privé,
            };

            _DbContext.FilmAfspeellijsts.Add(afspeellijst);
            _DbContext.SaveChanges();

            foreach (var item in model.Films)
            {
                if (item.Checked==true)
                {
                UserFilmAfspeelLijst usf = new UserFilmAfspeelLijst
                {
                    AfspeelLijstId = afspeellijst.Id,
                    FilmId = item.Id,
                    UserId = userId
                };
                _DbContext.UserFilmAfspeelLijsts.Add(usf);
                afspeellijst.UserFilmAfspeelLijsts.Add(usf);
                }
            }
            _DbContext.SaveChanges();

            return RedirectToAction("Index");
        }
        [Authorize]
        public IActionResult CreateMuziekAfspeellijst()
        {
            List<Muziek> filmsFromDb = new List<Muziek>();
            foreach (var item in _DbContext.Muziek)
            {
                filmsFromDb.Add(item);
            }

            List<FilmViewModel> films = new List<FilmViewModel>();
            foreach (var item in filmsFromDb)
            {
                films.Add(new FilmViewModel
                {
                    Naam = item.Titel,
                    Id = item.Id
                });
            }

            CreateFilmAfspeellijst model = new CreateFilmAfspeellijst();
            model.Films = films;
            return View(model);
        }
        [HttpPost]
        [Authorize]
        public IActionResult CreateMuziekAfspeellijst(CreateFilmAfspeellijst model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            MuziekAfspeelLijst afspeellijst = new MuziekAfspeelLijst()
            {
                Titel = model.Titel,
                Beschrijving = model.Beschrijving,
                Privé = model.Privé,
            };

            _DbContext.MuziekAfspeellijsts.Add(afspeellijst);

            foreach (var item in model.Films)
            {
                if (item.Checked == true)
                {
                    UserMuziekAfspeellijst usf = new UserMuziekAfspeellijst
                    {
                        MuziekAfspeelLijstId = afspeellijst.Id,
                        MuziekId = item.Id,
                        UserId = userId
                    };
                    _DbContext.UserMuziekAfspeelLijsts.Add(usf);
                    afspeellijst.UserMuziekAfspeellijst.Add(usf);
                }
            }
            if (afspeellijst.UserMuziekAfspeellijst != null)
            {
            _DbContext.SaveChanges();
            }

            return RedirectToAction("Index");
        }
        
    }
}
