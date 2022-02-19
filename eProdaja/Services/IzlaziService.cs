using AutoMapper;
using eProdaja.Database;
using eProdaja.Filters;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Korisnici = eProdaja.Model.Korisnici;

namespace eProdaja.Services
{
    public class IzlaziService : IIzlaziService
    {
        public eProdajaContext Context { get; set; }
        protected readonly IMapper _mapper;

        public IzlaziService(eProdajaContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }


        public IList<Model.Izlazi> GetAll(IzlaziSearchRequest search)
        {
            var query = Context.Izlazis.AsQueryable();

            if(search.VrstaProizvodaId != null)
            {
                query = query.Where(x => x.IzlazStavkes.Count(c => c.Proizvod.VrstaId == search.VrstaProizvodaId) > 0);
            }

            if (search.DatumOd != null)
            {
                query = query.Where(x => x.Datum.Date >= search.DatumOd.Value.Date);
            }
            if (search.DatumDo != null)
            {
                query = query.Where(x => x.Datum.Date <= search.DatumDo.Value.Date);
            }

            if(search.MinIznosPrometa != null)
                query = query.Where(x => x.IznosSaPdv >= search.MinIznosPrometa);

            var entities = query
                .Include(x=>x.Korisnik)
                .Include(x=>x.Narudzba.Kupac)
                .ToList();

            return _mapper.Map<List<Model.Izlazi>>(entities);
        }


    }
}
