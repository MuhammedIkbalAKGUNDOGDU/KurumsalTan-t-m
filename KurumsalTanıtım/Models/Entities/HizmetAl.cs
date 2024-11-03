using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalTanıtım.Models.Entities
{
    public class HizmetAl
    {
        public int HizmetAlId { get; set; }
        public string AdSoyad { get; set; }
        public string TelefonNo { get; set; }
        public string IlveIlce { get; set; }
        public int OdaSayisi { get; set; }
        public string TemizlikSikligi { get; set; }
    }
}
