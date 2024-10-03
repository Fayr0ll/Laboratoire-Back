using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_LaboBack.Migrations
{
    /// <inheritdoc />
    public partial class InitLaboDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auteurs",
                columns: table => new
                {
                    AuteurId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    NbrOuvrage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auteurs", x => x.AuteurId);
                });

            migrationBuilder.CreateTable(
                name: "Bibliotheques",
                columns: table => new
                {
                    BibliothequeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rue = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    CodePostal = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Localite = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Pays = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bibliotheques", x => x.BibliothequeId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomGenre = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Livres",
                columns: table => new
                {
                    ISBN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Edition = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AnneeEdition = table.Column<int>(type: "int", nullable: false),
                    Prix = table.Column<double>(type: "float", nullable: false),
                    Prime = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livres", x => x.ISBN);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Rue = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    CodePostal = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Localite = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Pays = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(364)", maxLength: 364, nullable: false),
                    MDP = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Salage = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "BibliothequeLivres",
                columns: table => new
                {
                    ISBN = table.Column<int>(type: "int", nullable: false),
                    BibliothequeId = table.Column<int>(type: "int", nullable: false),
                    StockDisponible = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BibliothequeLivres", x => new { x.ISBN, x.BibliothequeId });
                    table.ForeignKey(
                        name: "FK_BibliothequeLivres_Bibliotheques_BibliothequeId",
                        column: x => x.BibliothequeId,
                        principalTable: "Bibliotheques",
                        principalColumn: "BibliothequeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BibliothequeLivres_Livres_ISBN",
                        column: x => x.ISBN,
                        principalTable: "Livres",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ecrits",
                columns: table => new
                {
                    ISBN = table.Column<int>(type: "int", nullable: false),
                    AuteurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ecrits", x => new { x.ISBN, x.AuteurId });
                    table.ForeignKey(
                        name: "FK_Ecrits_Auteurs_AuteurId",
                        column: x => x.AuteurId,
                        principalTable: "Auteurs",
                        principalColumn: "AuteurId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ecrits_Livres_ISBN",
                        column: x => x.ISBN,
                        principalTable: "Livres",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenreDeLivres",
                columns: table => new
                {
                    ISBN = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreDeLivres", x => new { x.ISBN, x.GenreId });
                    table.ForeignKey(
                        name: "FK_GenreDeLivres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreDeLivres_Livres_ISBN",
                        column: x => x.ISBN,
                        principalTable: "Livres",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DebutLocation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RetourLocation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prix = table.Column<double>(type: "float", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                    table.ForeignKey(
                        name: "FK_Location_User",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ventes",
                columns: table => new
                {
                    VenteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prix = table.Column<double>(type: "float", nullable: false),
                    Quantitee = table.Column<int>(type: "int", nullable: false),
                    DateVente = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventes", x => x.VenteId);
                    table.ForeignKey(
                        name: "FK_Vente_User",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationDeLivres",
                columns: table => new
                {
                    ISBN = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationDeLivres", x => new { x.ISBN, x.LocationId });
                    table.ForeignKey(
                        name: "FK_LocationDeLivres_Livres_ISBN",
                        column: x => x.ISBN,
                        principalTable: "Livres",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationDeLivres_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VenteDeLivres",
                columns: table => new
                {
                    ISBN = table.Column<int>(type: "int", nullable: false),
                    VenteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VenteDeLivres", x => new { x.ISBN, x.VenteId });
                    table.ForeignKey(
                        name: "FK_VenteDeLivres_Livres_ISBN",
                        column: x => x.ISBN,
                        principalTable: "Livres",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VenteDeLivres_Ventes_VenteId",
                        column: x => x.VenteId,
                        principalTable: "Ventes",
                        principalColumn: "VenteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Auteurs_AuteurId",
                table: "Auteurs",
                column: "AuteurId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Auteurs_Nom_Prenom",
                table: "Auteurs",
                columns: new[] { "Nom", "Prenom" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BibliothequeLivres_BibliothequeId",
                table: "BibliothequeLivres",
                column: "BibliothequeId");

            migrationBuilder.CreateIndex(
                name: "IX_BibliothequeLivres_ISBN_BibliothequeId",
                table: "BibliothequeLivres",
                columns: new[] { "ISBN", "BibliothequeId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bibliotheques_BibliothequeId",
                table: "Bibliotheques",
                column: "BibliothequeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ecrits_AuteurId",
                table: "Ecrits",
                column: "AuteurId");

            migrationBuilder.CreateIndex(
                name: "IX_GenreDeLivres_GenreId",
                table: "GenreDeLivres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Genres_NomGenre",
                table: "Genres",
                column: "NomGenre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Livres_ISBN",
                table: "Livres",
                column: "ISBN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Livres_Titre_Edition",
                table: "Livres",
                columns: new[] { "Titre", "Edition" });

            migrationBuilder.CreateIndex(
                name: "IX_LocationDeLivres_LocationId",
                table: "LocationDeLivres",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_DebutLocation",
                table: "Locations",
                column: "DebutLocation",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_UserId",
                table: "Locations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VenteDeLivres_VenteId",
                table: "VenteDeLivres",
                column: "VenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventes_UserId",
                table: "Ventes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventes_VenteId",
                table: "Ventes",
                column: "VenteId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BibliothequeLivres");

            migrationBuilder.DropTable(
                name: "Ecrits");

            migrationBuilder.DropTable(
                name: "GenreDeLivres");

            migrationBuilder.DropTable(
                name: "LocationDeLivres");

            migrationBuilder.DropTable(
                name: "VenteDeLivres");

            migrationBuilder.DropTable(
                name: "Bibliotheques");

            migrationBuilder.DropTable(
                name: "Auteurs");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Livres");

            migrationBuilder.DropTable(
                name: "Ventes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
