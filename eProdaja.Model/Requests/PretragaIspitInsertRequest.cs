
using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.Model.Requests
{
    public class PretragaIspitInsertRequest
    {
        public int VrsteProizvodumId { get; set; }
        public int KorisniciId { get; set; }
        public decimal MinIznosPrometa { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public decimal IznosPrometa { get; set; }
    }
}
