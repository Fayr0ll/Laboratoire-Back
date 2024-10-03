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
    internal class EcritConfig : IEntityTypeConfiguration<Ecrit>
    {
        public void Configure(EntityTypeBuilder<Ecrit> builder)
        {
            builder.ToTable("Ecrits");

            builder
                .HasKey(ba => new { ba.ISBN, ba.AuteurId });

            builder
                .HasOne(ba => ba.Livre)
                .WithMany(b => b.Ecrits)
                .HasForeignKey(ba => ba.ISBN);

            builder
                .HasOne(ba => ba.Auteur)
                .WithMany(a => a.Ecrits)
                .HasForeignKey(ba => ba.AuteurId);
        }
    }
}
