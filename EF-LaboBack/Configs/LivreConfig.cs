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
    internal class LivreConfig : IEntityTypeConfiguration<Livre>
    {
        public void Configure(EntityTypeBuilder<Livre> builder)
        {
            builder.ToTable("Livres");

            builder
                .HasKey(l => l.ISBN);

            builder
                .Property(l => l.ISBN)
                .ValueGeneratedOnAdd();

            builder
                .HasIndex(l => l.ISBN)
                .IsUnique();

            builder
                .Property(l => l.Titre)
                .IsRequired();

            builder
                .Property(l => l.Edition)
                .IsRequired();

            builder
                .Property(l => l.AnneeEdition)
                .IsRequired();

            builder
                .Property(l => l.Prix)
                .IsRequired();

            builder
                .Property(l => l.Prime)
                .IsRequired();

            builder
                .HasIndex(b => new { b.Titre, b.Edition });
        }
    }
}
