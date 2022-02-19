using AutoMapper;
using eProdaja.Database;
using eProdaja.Model;
using eProdaja.Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using Proizvodi = eProdaja.Model.Proizvodi;

namespace eProdaja.Services
{
    public class PretragaIspitService : BaseCRUDService<Model.PretragaIspit, Database.PretragaIspit, PretragaIspitSearchRequest, PretragaIspitInsertRequest, PretragaIspitInsertRequest>, IPretragaIspitService
    {
        public PretragaIspitService(eProdajaContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
         
        public override IEnumerable<Model.PretragaIspit> Get(PretragaIspitSearchRequest search = null)
        {
            var entity = Context.Set<Database.PretragaIspit>().AsQueryable();

            if (search.KorisnikId.HasValue)
            {
                entity = entity.Where(x => x.KupciId == search.KorisnikId);
            }

            var list = entity
                .Include(x=>x.Kupci)
                .Include(x=>x.VrsteProizvodum)
                .ToList();

            var list2 = _mapper.Map<List<Model.PretragaIspit>>(list);

            foreach (var item in list2)
            {
                item.ProsječniPromet = Context.PretragaIspit.Where(x => x.KupciId == item.KorisniciId).Average(x => (decimal?) x.IznosPrometa) ?? 0;
            }

            return list2;
        }

      
    }


}
