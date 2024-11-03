using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalTanıtım.Models.Entities
{
    public class Iletisim
    {
        public int IletisimId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Issue { get; set; }
        public string Complaint { get; set; }
    }
}
