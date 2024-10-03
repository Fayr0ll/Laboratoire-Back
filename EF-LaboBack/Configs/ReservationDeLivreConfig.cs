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
    internal class ReservationDeLivreConfig : IEntityTypeConfiguration<ReservationDeLivre>
    {
        public void Configure(EntityTypeBuilder<ReservationDeLivre> builder)
        {
            builder.ToTable("ReservationDeLivres");

            builder
                .HasKey(rl => new { rl.ISBN, rl.ReservationId });

            builder
                .HasOne(rl => rl.Livre)
                .WithMany(l => l.ReservationsDesLivres)
                .HasForeignKey(rl => rl.ISBN);

            builder
                .HasOne(rl => rl.Reservation)
                .WithMany(r => r.ReservationsDesLivres)
                .HasForeignKey(rl => rl.ReservationId);
        }
    }
}
