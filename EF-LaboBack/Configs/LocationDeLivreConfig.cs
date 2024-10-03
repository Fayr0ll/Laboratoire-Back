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
    internal class LocationDeLivreConfig : IEntityTypeConfiguration<LocationDeLivre>
    {
        public void Configure(EntityTypeBuilder<LocationDeLivre> builder)
        {
            builder.ToTable("LocationDeLivres");

            builder
                .HasKey(loli => new { loli.ISBN, loli.LocationId });

            builder
                .HasOne(loli => loli.Livre)
                .WithMany(li => li.LocationsDesLivres)
                .HasForeignKey(loli => loli.ISBN);

            builder
                .HasOne(loli => loli.Location)
                .WithMany(lo => lo.LocationsDesLivres)
                .HasForeignKey(loli => loli.LocationId);
        }
    }
}
