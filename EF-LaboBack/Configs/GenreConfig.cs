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
    internal class GenreConfig : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("Genres");

            builder
                .HasKey(g => g.GenreId);

            builder
                .Property(g => g.GenreId)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder
                .Property(g => g.NomGenre)
                .HasMaxLength(32)
                .IsRequired();

            builder
                .HasIndex(g => g.NomGenre)
                .IsUnique();
        }
    }
}
