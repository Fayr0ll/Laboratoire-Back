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
    internal class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder
                .HasKey(u => u.UserId);

            builder
                .Property(u => u.Nom)
                .IsRequired()
                .HasMaxLength(32);

            builder
                .Property(u => u.Prenom)
                .IsRequired()
                .HasMaxLength(32);

            builder
                .Property(u => u.Rue)
                .IsRequired()
                .HasMaxLength(250);

            builder
                .Property(u => u.Numero)
                .IsRequired()
                .HasMaxLength(8);

            builder
                .Property(u => u.CodePostal)
                .IsRequired()
                .HasMaxLength(8);

            builder
                .Property(u => u.Localite)
                .IsRequired()
                .HasMaxLength(32);

            builder
                .Property(u => u.Pays)
                .IsRequired()
                .HasMaxLength(32);

            builder
                .Property(a => a.Email)
                .IsRequired()
                .HasMaxLength(364);

            builder
                .HasIndex(a => a.Email)
                .IsUnique();

            builder
                .Property(a => a.MDP)
                .IsRequired()
                .HasMaxLength(16);

            builder
                .Property(a => a.Salage)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
