using KurumsalTanıtım.Models;
using KurumsalTanıtım.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalTanıtım.Repositories.İmpl
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public readonly DBContext _dbContext;
        public EmployeeRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _dbContext.Set<Employee>().ToListAsync();
        }
    }
}
