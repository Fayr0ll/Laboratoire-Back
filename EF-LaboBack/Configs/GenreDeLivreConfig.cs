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
    internal class GenreDeLivreConfig : IEntityTypeConfiguration<GenreDeLivre>
    {
        public void Configure(EntityTypeBuilder<GenreDeLivre> builder)
        {
            builder.ToTable("GenreDeLivres");

            builder
                .HasKey(gl => new { gl.ISBN, gl.GenreId });

            builder
                .HasOne(gl => gl.Livre)
                .WithMany(l => l.GenresDesLivres)
                .HasForeignKey(gl => gl.ISBN);

            builder
                .HasOne(gl => gl.Genre)
                .WithMany(g => g.GenresDesLivres)
                .HasForeignKey(gl => gl.GenreId);
        }
    }
}
