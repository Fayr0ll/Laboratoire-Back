using EF_LaboBack.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_LaboBack.Configs
{
    public class ReservationConfig : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.ToTable("Reservations");

            builder
                .HasKey(r => r.ReservationId);

            builder
                .Property(r => r.ReservationId)
                .ValueGeneratedOnAdd();

            builder
                .Property(r => r.DateReservation)
                .IsRequired();

            builder
                .Property(r => r.Acompte)
                .IsRequired();

            builder
                .HasOne(r => r.User)
                .WithMany(u => u.Reservations)
                .HasForeignKey(l => l.UserId)
                .HasConstraintName("FK_Reservation_User");
        }
    }
}
