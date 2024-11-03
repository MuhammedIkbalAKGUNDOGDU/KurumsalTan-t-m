using KurumsalTanıtım.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalTanıtım.Repositories
{

    public interface IHizmetAlRepository
    {
        Task AddHizmetAl(HizmetAl hizmetal);
    }
}
