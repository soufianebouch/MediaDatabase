using System;
using System.Collections.Generic;
using System.Text;
using MediaLibrary.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MediaLibrary.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<RatingFilm> RatingFilms { get; set; }
        public DbSet<UserFilmGezienStatus> UserFilmGezienStatuses { get; set; }
        public DbSet<FilmAfspeellijst> FilmAfspeellijsts { get; set; }
        public DbSet<UserFilmAfspeelLijst> UserFilmAfspeelLijsts { get; set; }


        public DbSet<Serie> Series { get; set; }
        public DbSet<RatingSerie> RatingSeries { get; set; }
        public DbSet<UserSerieGezienStatus> UserSerieGezienStatuses { get; set; }
        public DbSet<SerieAfspeellijst> SerieAfspeellijsts { get; set; }
        public DbSet<UserSerieAfspeelLijst> UserSerieAfspeelLijsts { get; set; }

        public DbSet<Muziek> Muziek { get; set; }
        public DbSet<RatingMuziek> RatingMuziek { get; set; }
        public DbSet<UserMuziekGeluisterdStatus> userMuziekGeluisterdStatuses { get; set; }
        public DbSet<MuziekAfspeelLijst> MuziekAfspeellijsts { get; set; }
        public DbSet<UserMuziekAfspeellijst> UserMuziekAfspeelLijsts { get; set; }


        public DbSet<Podcast> Podcasts { get; set; }
        public DbSet<RatingPodcast> RatingPodcasts { get; set; }
        public DbSet<UserPodcastGeluisterdStatus> UserPodcastGeluisterdStatuses { get; set; }
        public DbSet<PodcastAfspeellijst> PodcastAfspeellijsts { get; set; }
        public DbSet<UserPodcastAfspeellijst> UserPodcastAfspeelLijsts { get; set; }


        public DbSet<GeluisterdStatus> GeluisterdStatuses { get; set; }
        public DbSet<GezienStatus> GezienStatusen { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<RatingFilm>().HasKey(r => new { r.FilmId, r.UserId });
            builder.Entity<UserFilmGezienStatus>().HasKey(u => new { u.FilmId, u.UserId, u.GezienStatusId });
            builder.Entity<UserFilmAfspeelLijst>().HasKey(u => new { u.FilmId, u.UserId, u.AfspeelLijstId });


            builder.Entity<RatingSerie>().HasKey(r => new { r.SerieId, r.UserId });
            builder.Entity<UserSerieGezienStatus>().HasKey(u => new { u.SerieId, u.UserId, u.GezienStatusId });
            builder.Entity<UserSerieAfspeelLijst>().HasKey(u => new { u.SerieId, u.UserId, u.SerieAfspeellijstId });


            builder.Entity<RatingMuziek>().HasKey(r => new { r.MuziekId, r.UserId });
            builder.Entity<UserMuziekGeluisterdStatus>().HasKey(u => new { u.MuziekId, u.UserId, u.GeluisterdStatusId });
            builder.Entity<UserMuziekAfspeellijst>().HasKey(u => new { u.MuziekId, u.UserId, u.MuziekAfspeelLijstId });


            builder.Entity<RatingPodcast>().HasKey(r => new { r.PodcastId, r.UserId });
            builder.Entity<UserPodcastGeluisterdStatus>().HasKey(u => new { u.PodcastId, u.UserId, u.GeluisterdStatusId });
            builder.Entity<UserPodcastAfspeellijst>().HasKey(u => new { u.PodcastId, u.UserId, u.PodcastAfspeellijstId });


            base.OnModelCreating(builder);
        }
    }
}
