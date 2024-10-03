using EF_LaboBack.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_LaboBack.Configs
{
    internal class AuteurConfig : IEntityTypeConfiguration<Auteur>
    {
        public void Configure(EntityTypeBuilder<Auteur> builder)
        {
            builder.ToTable("Auteurs");

            builder
                .HasKey(a => a.AuteurId);

            builder
                .Property(a => a.AuteurId)
                .ValueGeneratedOnAdd();

            builder
                .HasIndex(a => a.AuteurId)
                .IsUnique();

            builder
                .Property(a => a.Nom)
                .IsRequired()
                .HasMaxLength(32);

            builder
                .Property(a => a.Prenom)
                .IsRequired()
                .HasMaxLength(32);

            builder
                .Property(a => a.NbrOuvrage)
                .IsRequired();

            builder
                .HasIndex(a => new { a.Nom, a.Prenom })
                .IsUnique();
        }
    }
}
