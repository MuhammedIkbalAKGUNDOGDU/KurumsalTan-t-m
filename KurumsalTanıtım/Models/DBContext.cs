using DataAccessLayer.EntityConfigurations;
using KurumsalTanıtım.Models.Entities;
using KurumsalTanıtım.Models.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalTanıtım.Models
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuileder)
        {
            modelBuileder.ApplyConfiguration(new EmployeeEntityConfigurations());
            modelBuileder.ApplyConfiguration(new HizmetlerEntityConfigurations());
            modelBuileder.ApplyConfiguration(new IletisimEntityConfigurations());
            modelBuileder.ApplyConfiguration(new HizmetAlEntityConfigurations());
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Hizmetler> Hizmetlers { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<HizmetAl> HizmetAls { get; set; }
    }
}
