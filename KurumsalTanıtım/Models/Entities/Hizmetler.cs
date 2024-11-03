using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalTanıtım.Models.Entities
{
    public class Hizmetler
    {
        public int HizmetId { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string ImagePath { get; set; } 
    }
}
