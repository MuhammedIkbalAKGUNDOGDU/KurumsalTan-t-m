using KurumsalTanıtım.Models;
using KurumsalTanıtım.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalTanıtım.Repositories.İmpl
{
    public class HizmetlerRepository : IHizmetlerRepository
    {
        private readonly DBContext _context;

        public HizmetlerRepository(DBContext context)
        {
            _context = context;
        }

        public IEnumerable<Hizmetler> GetAllHizmetler()
        {
            return _context.Hizmetlers.ToList();
        }

        public Hizmetler GetHizmetById(int id)
        {
            return _context.Hizmetlers.FirstOrDefault(h => h.HizmetId == id);
        }
    }
}
