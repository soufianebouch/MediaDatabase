﻿// <auto-generated />
using System;
using MediaLibrary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MediaLibrary.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MediaLibrary.Domain.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Foto");

                    b.Property<string>("Regisseur");

                    b.Property<string>("Titel")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("MediaLibrary.Domain.FilmAfspeellijst", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Beschrijving");

                    b.Property<bool>("Privé");

                    b.Property<string>("Titel")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("FilmAfspeellijsts");
                });

            modelBuilder.Entity("MediaLibrary.Domain.GeluisterdStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naam");

                    b.HasKey("Id");

                    b.ToTable("GeluisterdStatuses");
                });

            modelBuilder.Entity("MediaLibrary.Domain.GezienStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naam");

                    b.HasKey("Id");

                    b.ToTable("GezienStatusen");
                });

            modelBuilder.Entity("MediaLibrary.Domain.Muziek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Artiest");

                    b.Property<byte[]>("Foto");

                    b.Property<string>("Titel")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Muziek");
                });

            modelBuilder.Entity("MediaLibrary.Domain.MuziekAfspeelLijst", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Beschrijving");

                    b.Property<bool>("Privé");

                    b.Property<string>("Titel")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("MuziekAfspeellijsts");
                });

            modelBuilder.Entity("MediaLibrary.Domain.Podcast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Foto");

                    b.Property<int>("Lengte");

                    b.Property<string>("Titel")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Podcasts");
                });

            modelBuilder.Entity("MediaLibrary.Domain.PodcastAfspeellijst", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Beschrijving");

                    b.Property<bool>("Privé");

                    b.Property<string>("Titel")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("PodcastAfspeellijsts");
                });

            modelBuilder.Entity("MediaLibrary.Domain.RatingFilm", b =>
                {
                    b.Property<int>("FilmId");

                    b.Property<string>("UserId");

                    b.Property<string>("Review");

                    b.Property<int>("Score");

                    b.HasKey("FilmId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("RatingFilms");
                });

            modelBuilder.Entity("MediaLibrary.Domain.RatingMuziek", b =>
                {
                    b.Property<int>("MuziekId");

                    b.Property<string>("UserId");

                    b.Property<string>("Review");

                    b.Property<int>("Score");

                    b.HasKey("MuziekId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("RatingMuziek");
                });

            modelBuilder.Entity("MediaLibrary.Domain.RatingPodcast", b =>
                {
                    b.Property<int>("PodcastId");

                    b.Property<string>("UserId");

                    b.Property<string>("Review");

                    b.Property<int>("Score");

                    b.HasKey("PodcastId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("RatingPodcasts");
                });

            modelBuilder.Entity("MediaLibrary.Domain.RatingSerie", b =>
                {
                    b.Property<int>("SerieId");

                    b.Property<string>("UserId");

                    b.Property<string>("Review");

                    b.Property<int>("Score");

                    b.HasKey("SerieId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("RatingSeries");
                });

            modelBuilder.Entity("MediaLibrary.Domain.Serie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Foto");

                    b.Property<int>("HoeveelAfl");

                    b.Property<string>("Seizoen");

                    b.Property<string>("Titel")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("MediaLibrary.Domain.SerieAfspeellijst", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Beschrijving");

                    b.Property<bool>("Privé");

                    b.Property<string>("Titel")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("SerieAfspeellijsts");
                });

            modelBuilder.Entity("MediaLibrary.Domain.UserFilmAfspeelLijst", b =>
                {
                    b.Property<int>("FilmId");

                    b.Property<string>("UserId");

                    b.Property<int>("AfspeelLijstId");

                    b.HasKey("FilmId", "UserId", "AfspeelLijstId");

                    b.HasIndex("AfspeelLijstId");

                    b.HasIndex("UserId");

                    b.ToTable("UserFilmAfspeelLijsts");
                });

            modelBuilder.Entity("MediaLibrary.Domain.UserFilmGezienStatus", b =>
                {
                    b.Property<int>("FilmId");

                    b.Property<string>("UserId");

                    b.Property<int>("GezienStatusId");

                    b.HasKey("FilmId", "UserId", "GezienStatusId");

                    b.HasIndex("GezienStatusId");

                    b.HasIndex("UserId");

                    b.ToTable("UserFilmGezienStatuses");
                });

            modelBuilder.Entity("MediaLibrary.Domain.UserMuziekAfspeellijst", b =>
                {
                    b.Property<int>("MuziekId");

                    b.Property<string>("UserId");

                    b.Property<int>("MuziekAfspeelLijstId");

                    b.HasKey("MuziekId", "UserId", "MuziekAfspeelLijstId");

                    b.HasIndex("MuziekAfspeelLijstId");

                    b.HasIndex("UserId");

                    b.ToTable("UserMuziekAfspeelLijsts");
                });

            modelBuilder.Entity("MediaLibrary.Domain.UserMuziekGeluisterdStatus", b =>
                {
                    b.Property<int>("MuziekId");

                    b.Property<string>("UserId");

                    b.Property<int>("GeluisterdStatusId");

                    b.HasKey("MuziekId", "UserId", "GeluisterdStatusId");

                    b.HasIndex("GeluisterdStatusId");

                    b.HasIndex("UserId");

                    b.ToTable("userMuziekGeluisterdStatuses");
                });

            modelBuilder.Entity("MediaLibrary.Domain.UserPodcastAfspeellijst", b =>
                {
                    b.Property<int>("PodcastId");

                    b.Property<string>("UserId");

                    b.Property<int>("PodcastAfspeellijstId");

                    b.HasKey("PodcastId", "UserId", "PodcastAfspeellijstId");

                    b.HasIndex("PodcastAfspeellijstId");

                    b.HasIndex("UserId");

                    b.ToTable("UserPodcastAfspeelLijsts");
                });

            modelBuilder.Entity("MediaLibrary.Domain.UserPodcastGeluisterdStatus", b =>
                {
                    b.Property<int>("PodcastId");

                    b.Property<string>("UserId");

                    b.Property<int>("GeluisterdStatusId");

                    b.HasKey("PodcastId", "UserId", "GeluisterdStatusId");

                    b.HasIndex("GeluisterdStatusId");

                    b.HasIndex("UserId");

                    b.ToTable("UserPodcastGeluisterdStatuses");
                });

            modelBuilder.Entity("MediaLibrary.Domain.UserSerieAfspeelLijst", b =>
                {
                    b.Property<int>("SerieId");

                    b.Property<string>("UserId");

                    b.Property<int>("SerieAfspeellijstId");

                    b.HasKey("SerieId", "UserId", "SerieAfspeellijstId");

                    b.HasIndex("SerieAfspeellijstId");

                    b.HasIndex("UserId");

                    b.ToTable("UserSerieAfspeelLijsts");
                });

            modelBuilder.Entity("MediaLibrary.Domain.UserSerieGezienStatus", b =>
                {
                    b.Property<int>("SerieId");

                    b.Property<string>("UserId");

                    b.Property<int>("GezienStatusId");

                    b.HasKey("SerieId", "UserId", "GezienStatusId");

                    b.HasIndex("GezienStatusId");

                    b.HasIndex("UserId");

                    b.ToTable("UserSerieGezienStatuses");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MediaLibrary.Domain.RatingFilm", b =>
                {
                    b.HasOne("MediaLibrary.Domain.Film", "Film")
                        .WithMany("Ratings")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MediaLibrary.Domain.RatingMuziek", b =>
                {
                    b.HasOne("MediaLibrary.Domain.Muziek", "Muziek")
                        .WithMany("Ratings")
                        .HasForeignKey("MuziekId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MediaLibrary.Domain.RatingPodcast", b =>
                {
                    b.HasOne("MediaLibrary.Domain.Podcast", "Podcast")
                        .WithMany("Ratings")
                        .HasForeignKey("PodcastId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MediaLibrary.Domain.RatingSerie", b =>
                {
                    b.HasOne("MediaLibrary.Domain.Serie", "Serie")
                        .WithMany("Ratings")
                        .HasForeignKey("SerieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MediaLibrary.Domain.UserFilmAfspeelLijst", b =>
                {
                    b.HasOne("MediaLibrary.Domain.FilmAfspeellijst", "Afspeellijst")
                        .WithMany("UserFilmAfspeelLijsts")
                        .HasForeignKey("AfspeelLijstId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MediaLibrary.Domain.Film", "Film")
                        .WithMany("FilmUserAfspeelLijst")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MediaLibrary.Domain.UserFilmGezienStatus", b =>
                {
                    b.HasOne("MediaLibrary.Domain.Film", "Film")
                        .WithMany("UserFilmGezienStatuses")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MediaLibrary.Domain.GezienStatus", "GezienStatus")
                        .WithMany("UserFilmGezienStatuses")
                        .HasForeignKey("GezienStatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MediaLibrary.Domain.UserMuziekAfspeellijst", b =>
                {
                    b.HasOne("MediaLibrary.Domain.MuziekAfspeelLijst", "MuziekAfspeellijst")
                        .WithMany("UserMuziekAfspeellijst")
                        .HasForeignKey("MuziekAfspeelLijstId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MediaLibrary.Domain.Muziek", "Muziek")
                        .WithMany("MuziekUserAfspeelLijst")
                        .HasForeignKey("MuziekId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MediaLibrary.Domain.UserMuziekGeluisterdStatus", b =>
                {
                    b.HasOne("MediaLibrary.Domain.GeluisterdStatus", "GeluisterdStatus")
                        .WithMany("UserMuziekGeluisterdStatuses")
                        .HasForeignKey("GeluisterdStatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MediaLibrary.Domain.Muziek", "Podcast")
                        .WithMany("UserMuziekGeluisterdStatuses")
                        .HasForeignKey("MuziekId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MediaLibrary.Domain.UserPodcastAfspeellijst", b =>
                {
                    b.HasOne("MediaLibrary.Domain.PodcastAfspeellijst", "PodcastAfspeellijst")
                        .WithMany("UserPodcastAfspeellijst")
                        .HasForeignKey("PodcastAfspeellijstId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MediaLibrary.Domain.Podcast", "Podcast")
                        .WithMany("PodcastUserAfspeelLijst")
                        .HasForeignKey("PodcastId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MediaLibrary.Domain.UserPodcastGeluisterdStatus", b =>
                {
                    b.HasOne("MediaLibrary.Domain.GeluisterdStatus", "GeluisterdStatus")
                        .WithMany("UserPodcastGeluisterdStatuses")
                        .HasForeignKey("GeluisterdStatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MediaLibrary.Domain.Podcast", "Podcast")
                        .WithMany("UserPodcastGeluisterdStatuses")
                        .HasForeignKey("PodcastId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MediaLibrary.Domain.UserSerieAfspeelLijst", b =>
                {
                    b.HasOne("MediaLibrary.Domain.SerieAfspeellijst", "SerieAfspeellijst")
                        .WithMany("UserSerieAfspeelLijsts")
                        .HasForeignKey("SerieAfspeellijstId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MediaLibrary.Domain.Serie", "Serie")
                        .WithMany("SerieUserAfspeelLijst")
                        .HasForeignKey("SerieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MediaLibrary.Domain.UserSerieGezienStatus", b =>
                {
                    b.HasOne("MediaLibrary.Domain.GezienStatus", "GezienStatus")
                        .WithMany("UserSerieGezienStatuses")
                        .HasForeignKey("GezienStatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MediaLibrary.Domain.Serie", "Serie")
                        .WithMany("UserSerieGezienStatuses")
                        .HasForeignKey("SerieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
