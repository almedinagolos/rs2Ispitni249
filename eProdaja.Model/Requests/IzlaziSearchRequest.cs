using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.Model.Requests
{
    public class IzlaziSearchRequest
    {
        public int? VrstaProizvodaId { get; set; }
        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
        public decimal? MinIznosPrometa { get; set; }
    }
}
