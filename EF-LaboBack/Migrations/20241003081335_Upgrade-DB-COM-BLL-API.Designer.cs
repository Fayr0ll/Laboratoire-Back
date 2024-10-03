﻿// <auto-generated />
using System;
using EF_LaboBack;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_LaboBack.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241003081335_Upgrade-DB-COM-BLL-API")]
    partial class UpgradeDBCOMBLLAPI
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF_LaboBack.Entities.Auteur", b =>
                {
                    b.Property<int>("AuteurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuteurId"));

                    b.Property<int>("NbrOuvrage")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("AuteurId");

                    b.HasIndex("AuteurId")
                        .IsUnique();

                    b.HasIndex("Nom", "Prenom")
                        .IsUnique();

                    b.ToTable("Auteurs", (string)null);
                });

            modelBuilder.Entity("EF_LaboBack.Entities.Bibliotheque", b =>
                {
                    b.Property<int>("BibliothequeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BibliothequeId"));

                    b.Property<string>("CodePostal")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Localite")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Pays")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Rue")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("BibliothequeId");

                    b.HasIndex("BibliothequeId")
                        .IsUnique();

                    b.ToTable("Bibliotheques", (string)null);
                });

            modelBuilder.Entity("EF_LaboBack.Entities.BibliothequeLivre", b =>
                {
                    b.Property<int>("ISBN")
                        .HasColumnType("int");

                    b.Property<int>("BibliothequeId")
                        .HasColumnType("int");

                    b.Property<int>("StockDisponible")
                        .HasColumnType("int");

                    b.HasKey("ISBN", "BibliothequeId");

                    b.HasIndex("BibliothequeId");

                    b.HasIndex("ISBN", "BibliothequeId")
                        .IsUnique();

                    b.ToTable("BibliothequeLivres", (string)null);
                });

            modelBuilder.Entity("EF_LaboBack.Entities.Ecrit", b =>
                {
                    b.Property<int>("ISBN")
                        .HasColumnType("int");

                    b.Property<int>("AuteurId")
                        .HasColumnType("int");

                    b.HasKey("ISBN", "AuteurId");

                    b.HasIndex("AuteurId");

                    b.ToTable("Ecrits", (string)null);
                });

            modelBuilder.Entity("EF_LaboBack.Entities.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"));

                    b.Property<string>("NomGenre")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("GenreId");

                    b.HasIndex("NomGenre")
                        .IsUnique();

                    b.ToTable("Genres", (string)null);
                });

            modelBuilder.Entity("EF_LaboBack.Entities.GenreDeLivre", b =>
                {
                    b.Property<int>("ISBN")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("ISBN", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("GenreDeLivres", (string)null);
                });

            modelBuilder.Entity("EF_LaboBack.Entities.Livre", b =>
                {
                    b.Property<int>("ISBN")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ISBN"));

                    b.Property<int>("AnneeEdition")
                        .HasColumnType("int");

                    b.Property<string>("Edition")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Prime")
                        .HasColumnType("bit");

                    b.Property<double>("Prix")
                        .HasColumnType("float");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ISBN");

                    b.HasIndex("ISBN")
                        .IsUnique();

                    b.HasIndex("Titre", "Edition");

                    b.ToTable("Livres", (string)null);
                });

            modelBuilder.Entity("EF_LaboBack.Entities.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationId"));

                    b.Property<DateTime>("DebutLocation")
                        .HasColumnType("datetime2");

                    b.Property<double?>("Prix")
                        .HasColumnType("float");

                    b.Property<DateTime?>("RetourLocation")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LocationId");

                    b.HasIndex("DebutLocation")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Locations", (string)null);
                });

            modelBuilder.Entity("EF_LaboBack.Entities.LocationDeLivre", b =>
                {
                    b.Property<int>("ISBN")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.HasKey("ISBN", "LocationId");

                    b.HasIndex("LocationId");

                    b.ToTable("LocationDeLivres", (string)null);
                });

            modelBuilder.Entity("EF_LaboBack.Entities.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"));

                    b.Property<double>("Acompte")
                        .HasColumnType("float");

                    b.Property<DateTime>("DateReservation")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ReservationId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations", (string)null);
                });

            modelBuilder.Entity("EF_LaboBack.Entities.ReservationDeLivre", b =>
                {
                    b.Property<int>("ISBN")
                        .HasColumnType("int");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.HasKey("ISBN", "ReservationId");

                    b.HasIndex("ReservationId");

                    b.ToTable("ReservationDeLivres", (string)null);
                });

            modelBuilder.Entity("EF_LaboBack.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("CodePostal")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(364)
                        .HasColumnType("nvarchar(364)");

                    b.Property<string>("Localite")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("MDP")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Pays")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Rue")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Salage")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("EF_LaboBack.Entities.Vente", b =>
                {
                    b.Property<int>("VenteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VenteId"));

                    b.Property<DateTime>("DateVente")
                        .HasColumnType("datetime2");

                    b.Property<double>("Prix")
                        .HasColumnType("float");

                    b.Property<int>("Quantitee")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("VenteId");

                    b.HasIndex("UserId");

                    b.HasIndex("VenteId")
                        .IsUnique();

                    b.ToTable("Ventes", (string)null);
                });

            modelBuilder.Entity("EF_LaboBack.Entities.VenteDeLivre", b =>
                {
                    b.Property<int>("ISBN")
                        .HasColumnType("int");

                    b.Property<int>("VenteId")
                        .HasColumnType("int");

                    b.HasKey("ISBN", "VenteId");

                    b.HasIndex("VenteId");

                    b.ToTable("VenteDeLivres", (string)null);
                });

            modelBuilder.Entity("EF_LaboBack.Entities.BibliothequeLivre", b =>
                {
                    b.HasOne("EF_LaboBack.Entities.Bibliotheque", "Bibliotheque")
                        .WithMany("BibliothequesLivres")
                        .HasForeignKey("BibliothequeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_LaboBack.Entities.Livre", "Livre")
                        .WithMany("BibliothequesLivres")
                        .HasForeignKey("ISBN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bibliotheque");

                    b.Navigation("Livre");
                });

            modelBuilder.Entity("EF_LaboBack.Entities.Ecrit", b =>
                {
                    b.HasOne("EF_LaboBack.Entities.Auteur", "Auteur")
                        .WithMany("Ecrits")
                        .HasForeignKey("AuteurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_LaboBack.Entities.Livre", "Livre")
                        .WithMany("Ecrits")
                        .HasForeignKey("ISBN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auteur");

                    b.Navigation("Livre");
                });

            modelBuilder.Entity("EF_LaboBack.Entities.GenreDeLivre", b =>
                {
                    b.HasOne("EF_LaboBack.Entities.Genre", "Genre")
                        .WithMany("GenresDesLivres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_LaboBack.Entities.Livre", "Livre")
                        .WithMany("GenresDesLivres")
                        .HasForeignKey("ISBN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Livre");
                });

            modelBuilder.Entity("EF_LaboBack.Entities.Location", b =>
                {
                    b.HasOne("EF_LaboBack.Entities.User", "User")
                        .WithMany("Locations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Location_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EF_LaboBack.Entities.LocationDeLivre", b =>
                {
                    b.HasOne("EF_LaboBack.Entities.Livre", "Livre")
                        .WithMany("LocationsDesLivres")
                        .HasForeignKey("ISBN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_LaboBack.Entities.Location", "Location")
                        .WithMany("LocationsDesLivres")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livre");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("EF_LaboBack.Entities.Reservation", b =>
                {
                    b.HasOne("EF_LaboBack.Entities.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Reservation_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EF_LaboBack.Entities.ReservationDeLivre", b =>
                {
                    b.HasOne("EF_LaboBack.Entities.Livre", "Livre")
                        .WithMany("ReservationsDesLivres")
                        .HasForeignKey("ISBN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_LaboBack.Entities.Reservation", "Reservation")
                        .WithMany("ReservationsDesLivres")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livre");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("EF_LaboBack.Entities.Vente", b =>
                {
                    b.HasOne("EF_LaboBack.Entities.User", "User")
                        .WithMany("Ventes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Vente_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EF_LaboBack.Entities.VenteDeLivre", b =>
                {
                    b.HasOne("EF_LaboBack.Entities.Livre", "Livre")
                        .WithMany("VentesDesLivres")
                        .HasForeignKey("ISBN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_LaboBack.Entities.Vente", "Vente")
                        .WithMany("VentesDesLivres")
                        .HasForeignKey("VenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livre");

                    b.Navigation("Vente");
                });

            modelBuilder.Entity("EF_LaboBack.Entities.Auteur", b =>
                {
                    b.Navigation("Ecrits");
                });

            modelBuilder.Entity("EF_LaboBack.Entities.Bibliotheque", b =>
                {
                    b.Navigation("BibliothequesLivres");
                });

            modelBuilder.Entity("EF_LaboBack.Entities.Genre", b =>
                {
                    b.Navigation("GenresDesLivres");
                });

            modelBuilder.Entity("EF_LaboBack.Entities.Livre", b =>
                {
                    b.Navigation("BibliothequesLivres");

                    b.Navigation("Ecrits");

                    b.Navigation("GenresDesLivres");

                    b.Navigation("LocationsDesLivres");

                    b.Navigation("ReservationsDesLivres");

                    b.Navigation("VentesDesLivres");
                });

            modelBuilder.Entity("EF_LaboBack.Entities.Location", b =>
                {
                    b.Navigation("LocationsDesLivres");
                });

            modelBuilder.Entity("EF_LaboBack.Entities.Reservation", b =>
                {
                    b.Navigation("ReservationsDesLivres");
                });

            modelBuilder.Entity("EF_LaboBack.Entities.User", b =>
                {
                    b.Navigation("Locations");

                    b.Navigation("Reservations");

                    b.Navigation("Ventes");
                });

            modelBuilder.Entity("EF_LaboBack.Entities.Vente", b =>
                {
                    b.Navigation("VentesDesLivres");
                });
#pragma warning restore 612, 618
        }
    }
}
