using EF_LaboBack.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_LaboBack.Configs
{
    internal class BibliothequeLivreConfig : IEntityTypeConfiguration<BibliothequeLivre>
    {
        public void Configure(EntityTypeBuilder<BibliothequeLivre> builder)
        {
            builder.ToTable("BibliothequeLivres");

            builder
                .HasKey(bl => new { bl.ISBN, bl.BibliothequeId });

            builder
                .HasOne(bl => bl.Livre)
                .WithMany(b => b.BibliothequesLivres)
                .HasForeignKey(bl => bl.ISBN);

            builder
                .HasOne(bl => bl.Bibliotheque)
                .WithMany(l => l.BibliothequesLivres)
                .HasForeignKey(bl => bl.BibliothequeId);

            builder
                .Property(bl => bl.StockDisponible)
                .IsRequired();

            builder
                .HasIndex(bl => new { bl.ISBN, bl.BibliothequeId })
                .IsUnique();
        }
    }
}
