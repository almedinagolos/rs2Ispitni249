using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Database
{
    public class PretragaIspit
    {
        public int Id { get; set; }
        public VrsteProizvodum VrsteProizvodum { get; set; }
        public int VrsteProizvodumId { get; set; }
        public Kupci Kupci { get; set; }
        public int KupciId { get; set; }
        public decimal MinIznosPrometa { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public decimal IznosPrometa { get; set; }
    }
}
