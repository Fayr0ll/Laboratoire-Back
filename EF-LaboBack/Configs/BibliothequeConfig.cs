using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EF_LaboBack.Entities;

namespace EF_LaboBack.Configs
{
    internal class BibliothequeConfig : IEntityTypeConfiguration<Bibliotheque>
    {
        public void Configure(EntityTypeBuilder<Bibliotheque> builder)
        {
            builder.ToTable("Bibliotheques");

            builder
                .HasKey(l => l.BibliothequeId);

            builder
                .HasIndex(l => l.BibliothequeId)
                .IsUnique();

            builder
                .Property(l => l.BibliothequeId)
                .ValueGeneratedOnAdd();

            builder
                .Property(l => l.Rue)
                .HasMaxLength(250)
                .IsRequired();

            builder
                .Property(l => l.Numero)
                .HasMaxLength(8)
                .IsRequired();

            builder
                .Property(l => l.CodePostal)
                .HasMaxLength(8)
                .IsRequired();

            builder
                .Property(l => l.Localite)
                .HasMaxLength(32)
                .IsRequired();

            builder
                .Property(l => l.Pays)
                .HasMaxLength(32)
                .IsRequired();

        }
    }
}
