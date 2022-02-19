using eProdaja.Model;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public interface IPretragaIspitService : ICRUDService<PretragaIspit, PretragaIspitSearchRequest, PretragaIspitInsertRequest, PretragaIspitInsertRequest>
    {
    }
}
