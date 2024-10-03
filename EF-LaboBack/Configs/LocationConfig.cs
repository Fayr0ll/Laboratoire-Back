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
    internal class LocationConfig : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.ToTable("Locations");

            builder
                .HasKey(l => l.LocationId);

            builder
                .HasIndex(l => l.DebutLocation)
                .IsUnique();

            builder
                .Property(l => l.LocationId)
                .ValueGeneratedOnAdd();

            builder
                .Property(l => l.DebutLocation)
                .IsRequired();

            builder
                .Property(l => l.RetourLocation)
                .IsRequired(false);

            builder
                .Property(l => l.Prix)
                .IsRequired(false);

            builder
                .HasOne(l => l.User)
                .WithMany(c => c.Locations)
                .HasForeignKey(l => l.UserId)
                .HasConstraintName("FK_Location_User");
        }
    }
}
