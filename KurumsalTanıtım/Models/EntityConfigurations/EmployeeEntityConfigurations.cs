using KurumsalTanıtım.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityConfigurations
{
    public class EmployeeEntityConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

            builder.Property(x => x.Surname)
                .IsRequired().HasMaxLength(50);
            builder.HasIndex(x => x.Password)
                .IsUnique();
            builder.Property(x => x.Password)
                .IsRequired().HasMaxLength(50);
            builder.ToTable("employees");
        }
    }
}
