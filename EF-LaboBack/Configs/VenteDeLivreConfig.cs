using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_LaboBack.Entities;

namespace EF_LaboBack.Configs
{
    public class VenteDeLivreConfig : IEntityTypeConfiguration<VenteDeLivre>
    {
        public void Configure(EntityTypeBuilder<VenteDeLivre> builder)
        {
            builder.ToTable("VenteDeLivres");

            builder
                .HasKey(vl => new { vl.ISBN, vl.VenteId });

            builder
                .HasOne(vl => vl.Livre)
                .WithMany(l => l.VentesDesLivres)
                .HasForeignKey(vl => vl.ISBN);

            builder
                .HasOne(vl => vl.Vente)
                .WithMany(v => v.VentesDesLivres)
                .HasForeignKey(vl => vl.VenteId);
        }
    }
}
