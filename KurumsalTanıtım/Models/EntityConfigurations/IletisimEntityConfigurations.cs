using KurumsalTanıtım.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalTanıtım.Models.EntityConfigurations
{
    public class IletisimEntityConfigurations : IEntityTypeConfiguration<Iletisim>
    {
        public void Configure(EntityTypeBuilder<Iletisim> builder)
        {
            builder.HasKey(x => x.IletisimId);
            builder.Property(x => x.IletisimId).UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.HasIndex(x => x.Email)
                .IsUnique();
            builder.Property(x => x.Email)
                .IsRequired().HasMaxLength(50);
            
            builder.Property(x => x.Issue)
                .IsRequired().HasMaxLength(50);
            builder.Property(x => x.Complaint)
                .IsRequired().HasMaxLength(250);
            builder.ToTable("iletisims");
        }
    }
}
