using KurumsalTanıtım.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalTanıtım.Models.EntityConfigurations
{
    public class HizmetAlEntityConfigurations : IEntityTypeConfiguration<HizmetAl>
    {
        public void Configure(EntityTypeBuilder<HizmetAl> builder)
        {
            builder.HasKey(x => x.HizmetAlId);
            builder.Property(x => x.HizmetAlId).UseIdentityColumn();

            builder.Property(x => x.AdSoyad).IsRequired().HasMaxLength(50);

            builder.Property(x => x.TelefonNo)
                .IsRequired().HasMaxLength(20);
            builder.Property(x => x.IlveIlce)
                .IsRequired().HasMaxLength(20);
            builder.Property(x => x.TemizlikSikligi)
                .IsRequired().HasMaxLength(20);

            builder.ToTable("hizmetals");
        }
    }
}
