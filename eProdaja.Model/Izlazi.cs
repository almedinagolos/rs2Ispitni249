using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.Model
{
    public class Izlazi
    {
        public int IzlazId { get; set; }
        public int KorisnikId { get; set; }
        public decimal IznosSaPdv { get; set; }
        public int? NarudzbaId { get; set; }

        public virtual Korisnici Korisnik { get; set; }
        public virtual Narudzbe Narudzba { get; set; }
        public string Kupac { get { return Narudzba.Kupac.ToString(); } }
    }
}
