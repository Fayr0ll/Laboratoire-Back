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
    internal class VenteConfig : IEntityTypeConfiguration<Vente>
    {
        public void Configure(EntityTypeBuilder<Vente> builder)
        {
            builder.ToTable("Ventes");

            builder
                .HasKey(v => v.VenteId);

            builder
                .HasIndex(v => v.VenteId)
                .IsUnique();

            builder
                .Property(v => v.VenteId)
                .ValueGeneratedOnAdd();

            builder
                .Property(v => v.Prix)
                .IsRequired();

            builder
                .Property(v => v.Quantitee)
                .IsRequired();

            builder
                .Property(v => v.DateVente)
                .IsRequired();

            builder
                .HasOne(v => v.User)
                .WithMany(u => u.Ventes)
                .HasForeignKey(v => v.UserId)
                .HasConstraintName("FK_Vente_User");
        }
    }
}
