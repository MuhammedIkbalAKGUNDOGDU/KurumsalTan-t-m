using KurumsalTanıtım.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalTanıtım.Models.EntityConfigurations
{
    public class HizmetlerEntityConfigurations : IEntityTypeConfiguration<Hizmetler>
    {
        public void Configure(EntityTypeBuilder<Hizmetler> builder)
        {
            builder.HasKey(x => x.HizmetId);
            builder.Property(x => x.HizmetId).UseIdentityColumn();

            builder.Property(x => x.Baslik).IsRequired().HasMaxLength(50);

            builder.Property(x => x.Aciklama)
                .IsRequired().HasMaxLength(1000);
            builder.Property(x => x.ImagePath)
                .IsRequired().HasMaxLength(250);

            builder.ToTable("hizmetlers");
        }
    }
}
