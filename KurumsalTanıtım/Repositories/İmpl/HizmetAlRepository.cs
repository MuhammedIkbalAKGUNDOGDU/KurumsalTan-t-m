using KurumsalTanıtım.Models;
using KurumsalTanıtım.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalTanıtım.Repositories.İmpl
{
    public class HizmetAlRepository : IHizmetAlRepository
    {
        private readonly DBContext _context;

        public HizmetAlRepository(DBContext context)
        {
            _context = context;
        }
        public async Task AddHizmetAl(HizmetAl hizmetal)
        {
            
                await _context.AddAsync(hizmetal);
                await _context.SaveChangesAsync();
            
        }
    }
}
