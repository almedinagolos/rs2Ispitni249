using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Model
{
    public class PretragaIspit
    {
        public int Id { get; set; }
        public VrsteProizvodum VrsteProizvodum { get; set; }
        public int VrsteProizvodumId { get; set; }
        public Korisnici Korisnici { get; set; }
        public int KorisniciId { get; set; }
        public decimal MinIznosPrometa { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public decimal IznosPrometa { get; set; }
        public decimal ProsječniPromet { get; set; }
    }
}
