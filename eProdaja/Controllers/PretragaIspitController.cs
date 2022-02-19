using eProdaja.Model;
using eProdaja.Model.Requests;
using eProdaja.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    public class PretragaIspitController : BaseCRUDController<Model.PretragaIspit, PretragaIspitSearchRequest, PretragaIspitInsertRequest, PretragaIspitInsertRequest>
    {
        public PretragaIspitController(IPretragaIspitService service) : base(service)
        {
        }

    }
}
