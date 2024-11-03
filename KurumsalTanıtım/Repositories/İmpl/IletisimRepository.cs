using KurumsalTanıtım.Models;
using KurumsalTanıtım.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KurumsalTanıtım.Repositories.İmpl
{
    public class IletisimRepository : IIletisimRepository
    {
        private readonly DBContext _context;

        public IletisimRepository(DBContext context)
        {
            _context = context;
        }
        public async Task AddIletisim(Iletisim iletisim)
        {
            await _context.AddAsync(iletisim);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Iletisim>> GetAll()
        {
            return await _context.Set<Iletisim>().ToListAsync();
        }
    }
}
