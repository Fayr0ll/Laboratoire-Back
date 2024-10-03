using EF_LaboBack.Configs;
using EF_LaboBack.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_LaboBack
{
    public class DataContext : DbContext
    {
        public DbSet<Livre> Livres { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vente> Ventes { get; set; }
        public DbSet<Bibliotheque> Bibliotheques { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Auteur> Auteurs { get; set; }
        public DbSet<Ecrit> Ecrits { get; set; }
        public DbSet<GenreDeLivre> GenreDeLivres { get; set; }
        public DbSet<LocationDeLivre> LocationDeLivres { get; set; }
        public DbSet<BibliothequeLivre> BibliothequeLivres { get; set; }
        public DbSet<VenteDeLivre> VenteDeLivres { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationDeLivre> ReservationsDesLivres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Entity-Labo;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuteurConfig());
            modelBuilder.ApplyConfiguration(new BibliothequeConfig());
            modelBuilder.ApplyConfiguration(new BibliothequeLivreConfig());
            modelBuilder.ApplyConfiguration(new EcritConfig());
            modelBuilder.ApplyConfiguration(new GenreConfig());
            modelBuilder.ApplyConfiguration(new GenreDeLivreConfig());
            modelBuilder.ApplyConfiguration(new LivreConfig());
            modelBuilder.ApplyConfiguration(new LocationConfig());
            modelBuilder.ApplyConfiguration(new LocationDeLivreConfig());
            modelBuilder.ApplyConfiguration(new ReservationConfig());
            modelBuilder.ApplyConfiguration(new ReservationDeLivreConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new VenteConfig());
            modelBuilder.ApplyConfiguration(new VenteDeLivreConfig());
        }
    }
}
