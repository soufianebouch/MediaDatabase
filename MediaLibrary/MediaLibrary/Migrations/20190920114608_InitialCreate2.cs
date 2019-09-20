using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaLibrary.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilmAfspeellijsts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titel = table.Column<string>(maxLength: 100, nullable: true),
                    Beschrijving = table.Column<string>(nullable: true),
                    Privé = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmAfspeellijsts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titel = table.Column<string>(maxLength: 100, nullable: true),
                    Regisseur = table.Column<string>(nullable: true),
                    Foto = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeluisterdStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeluisterdStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GezienStatusen",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GezienStatusen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Muziek",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titel = table.Column<string>(maxLength: 100, nullable: true),
                    Artiest = table.Column<string>(nullable: true),
                    Foto = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muziek", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MuziekAfspeellijsts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titel = table.Column<string>(maxLength: 100, nullable: true),
                    Beschrijving = table.Column<string>(nullable: true),
                    Privé = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuziekAfspeellijsts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PodcastAfspeellijsts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titel = table.Column<string>(maxLength: 100, nullable: true),
                    Beschrijving = table.Column<string>(nullable: true),
                    Privé = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PodcastAfspeellijsts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Podcasts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titel = table.Column<string>(maxLength: 100, nullable: true),
                    Lengte = table.Column<int>(nullable: false),
                    Foto = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Podcasts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SerieAfspeellijsts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titel = table.Column<string>(maxLength: 100, nullable: true),
                    Beschrijving = table.Column<string>(nullable: true),
                    Privé = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerieAfspeellijsts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titel = table.Column<string>(maxLength: 100, nullable: true),
                    Seizoen = table.Column<string>(nullable: true),
                    HoeveelAfl = table.Column<int>(nullable: false),
                    Foto = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RatingFilms",
                columns: table => new
                {
                    FilmId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    Review = table.Column<string>(nullable: true),
                    Score = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RatingFilms", x => new { x.FilmId, x.UserId });
                    table.ForeignKey(
                        name: "FK_RatingFilms_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RatingFilms_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFilmAfspeelLijsts",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    AfspeelLijstId = table.Column<int>(nullable: false),
                    FilmId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFilmAfspeelLijsts", x => new { x.FilmId, x.UserId, x.AfspeelLijstId });
                    table.ForeignKey(
                        name: "FK_UserFilmAfspeelLijsts_FilmAfspeellijsts_AfspeelLijstId",
                        column: x => x.AfspeelLijstId,
                        principalTable: "FilmAfspeellijsts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFilmAfspeelLijsts_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFilmAfspeelLijsts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFilmGezienStatuses",
                columns: table => new
                {
                    FilmId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    GezienStatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFilmGezienStatuses", x => new { x.FilmId, x.UserId, x.GezienStatusId });
                    table.ForeignKey(
                        name: "FK_UserFilmGezienStatuses_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFilmGezienStatuses_GezienStatusen_GezienStatusId",
                        column: x => x.GezienStatusId,
                        principalTable: "GezienStatusen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFilmGezienStatuses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RatingMuziek",
                columns: table => new
                {
                    MuziekId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    Review = table.Column<string>(nullable: true),
                    Score = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RatingMuziek", x => new { x.MuziekId, x.UserId });
                    table.ForeignKey(
                        name: "FK_RatingMuziek_Muziek_MuziekId",
                        column: x => x.MuziekId,
                        principalTable: "Muziek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RatingMuziek_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "userMuziekGeluisterdStatuses",
                columns: table => new
                {
                    MuziekId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    GeluisterdStatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userMuziekGeluisterdStatuses", x => new { x.MuziekId, x.UserId, x.GeluisterdStatusId });
                    table.ForeignKey(
                        name: "FK_userMuziekGeluisterdStatuses_GeluisterdStatuses_GeluisterdStatusId",
                        column: x => x.GeluisterdStatusId,
                        principalTable: "GeluisterdStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_userMuziekGeluisterdStatuses_Muziek_MuziekId",
                        column: x => x.MuziekId,
                        principalTable: "Muziek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_userMuziekGeluisterdStatuses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserMuziekAfspeelLijsts",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    MuziekAfspeelLijstId = table.Column<int>(nullable: false),
                    MuziekId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMuziekAfspeelLijsts", x => new { x.MuziekId, x.UserId, x.MuziekAfspeelLijstId });
                    table.ForeignKey(
                        name: "FK_UserMuziekAfspeelLijsts_MuziekAfspeellijsts_MuziekAfspeelLijstId",
                        column: x => x.MuziekAfspeelLijstId,
                        principalTable: "MuziekAfspeellijsts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMuziekAfspeelLijsts_Muziek_MuziekId",
                        column: x => x.MuziekId,
                        principalTable: "Muziek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMuziekAfspeelLijsts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RatingPodcasts",
                columns: table => new
                {
                    PodcastId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    Review = table.Column<string>(nullable: true),
                    Score = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RatingPodcasts", x => new { x.PodcastId, x.UserId });
                    table.ForeignKey(
                        name: "FK_RatingPodcasts_Podcasts_PodcastId",
                        column: x => x.PodcastId,
                        principalTable: "Podcasts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RatingPodcasts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPodcastAfspeelLijsts",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    PodcastAfspeellijstId = table.Column<int>(nullable: false),
                    PodcastId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPodcastAfspeelLijsts", x => new { x.PodcastId, x.UserId, x.PodcastAfspeellijstId });
                    table.ForeignKey(
                        name: "FK_UserPodcastAfspeelLijsts_PodcastAfspeellijsts_PodcastAfspeellijstId",
                        column: x => x.PodcastAfspeellijstId,
                        principalTable: "PodcastAfspeellijsts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPodcastAfspeelLijsts_Podcasts_PodcastId",
                        column: x => x.PodcastId,
                        principalTable: "Podcasts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPodcastAfspeelLijsts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPodcastGeluisterdStatuses",
                columns: table => new
                {
                    PodcastId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    GeluisterdStatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPodcastGeluisterdStatuses", x => new { x.PodcastId, x.UserId, x.GeluisterdStatusId });
                    table.ForeignKey(
                        name: "FK_UserPodcastGeluisterdStatuses_GeluisterdStatuses_GeluisterdStatusId",
                        column: x => x.GeluisterdStatusId,
                        principalTable: "GeluisterdStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPodcastGeluisterdStatuses_Podcasts_PodcastId",
                        column: x => x.PodcastId,
                        principalTable: "Podcasts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPodcastGeluisterdStatuses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RatingSeries",
                columns: table => new
                {
                    SerieId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    Review = table.Column<string>(nullable: true),
                    Score = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RatingSeries", x => new { x.SerieId, x.UserId });
                    table.ForeignKey(
                        name: "FK_RatingSeries_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RatingSeries_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSerieAfspeelLijsts",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    SerieAfspeellijstId = table.Column<int>(nullable: false),
                    SerieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSerieAfspeelLijsts", x => new { x.SerieId, x.UserId, x.SerieAfspeellijstId });
                    table.ForeignKey(
                        name: "FK_UserSerieAfspeelLijsts_SerieAfspeellijsts_SerieAfspeellijstId",
                        column: x => x.SerieAfspeellijstId,
                        principalTable: "SerieAfspeellijsts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSerieAfspeelLijsts_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSerieAfspeelLijsts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSerieGezienStatuses",
                columns: table => new
                {
                    SerieId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    GezienStatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSerieGezienStatuses", x => new { x.SerieId, x.UserId, x.GezienStatusId });
                    table.ForeignKey(
                        name: "FK_UserSerieGezienStatuses_GezienStatusen_GezienStatusId",
                        column: x => x.GezienStatusId,
                        principalTable: "GezienStatusen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSerieGezienStatuses_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSerieGezienStatuses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RatingFilms_UserId",
                table: "RatingFilms",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RatingMuziek_UserId",
                table: "RatingMuziek",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RatingPodcasts_UserId",
                table: "RatingPodcasts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RatingSeries_UserId",
                table: "RatingSeries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFilmAfspeelLijsts_AfspeelLijstId",
                table: "UserFilmAfspeelLijsts",
                column: "AfspeelLijstId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFilmAfspeelLijsts_UserId",
                table: "UserFilmAfspeelLijsts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFilmGezienStatuses_GezienStatusId",
                table: "UserFilmGezienStatuses",
                column: "GezienStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFilmGezienStatuses_UserId",
                table: "UserFilmGezienStatuses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMuziekAfspeelLijsts_MuziekAfspeelLijstId",
                table: "UserMuziekAfspeelLijsts",
                column: "MuziekAfspeelLijstId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMuziekAfspeelLijsts_UserId",
                table: "UserMuziekAfspeelLijsts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_userMuziekGeluisterdStatuses_GeluisterdStatusId",
                table: "userMuziekGeluisterdStatuses",
                column: "GeluisterdStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_userMuziekGeluisterdStatuses_UserId",
                table: "userMuziekGeluisterdStatuses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPodcastAfspeelLijsts_PodcastAfspeellijstId",
                table: "UserPodcastAfspeelLijsts",
                column: "PodcastAfspeellijstId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPodcastAfspeelLijsts_UserId",
                table: "UserPodcastAfspeelLijsts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPodcastGeluisterdStatuses_GeluisterdStatusId",
                table: "UserPodcastGeluisterdStatuses",
                column: "GeluisterdStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPodcastGeluisterdStatuses_UserId",
                table: "UserPodcastGeluisterdStatuses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSerieAfspeelLijsts_SerieAfspeellijstId",
                table: "UserSerieAfspeelLijsts",
                column: "SerieAfspeellijstId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSerieAfspeelLijsts_UserId",
                table: "UserSerieAfspeelLijsts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSerieGezienStatuses_GezienStatusId",
                table: "UserSerieGezienStatuses",
                column: "GezienStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSerieGezienStatuses_UserId",
                table: "UserSerieGezienStatuses",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "RatingFilms");

            migrationBuilder.DropTable(
                name: "RatingMuziek");

            migrationBuilder.DropTable(
                name: "RatingPodcasts");

            migrationBuilder.DropTable(
                name: "RatingSeries");

            migrationBuilder.DropTable(
                name: "UserFilmAfspeelLijsts");

            migrationBuilder.DropTable(
                name: "UserFilmGezienStatuses");

            migrationBuilder.DropTable(
                name: "UserMuziekAfspeelLijsts");

            migrationBuilder.DropTable(
                name: "userMuziekGeluisterdStatuses");

            migrationBuilder.DropTable(
                name: "UserPodcastAfspeelLijsts");

            migrationBuilder.DropTable(
                name: "UserPodcastGeluisterdStatuses");

            migrationBuilder.DropTable(
                name: "UserSerieAfspeelLijsts");

            migrationBuilder.DropTable(
                name: "UserSerieGezienStatuses");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "FilmAfspeellijsts");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "MuziekAfspeellijsts");

            migrationBuilder.DropTable(
                name: "Muziek");

            migrationBuilder.DropTable(
                name: "PodcastAfspeellijsts");

            migrationBuilder.DropTable(
                name: "GeluisterdStatuses");

            migrationBuilder.DropTable(
                name: "Podcasts");

            migrationBuilder.DropTable(
                name: "SerieAfspeellijsts");

            migrationBuilder.DropTable(
                name: "GezienStatusen");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
