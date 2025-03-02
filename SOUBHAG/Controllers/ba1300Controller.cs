using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SOUBHAG.Service;
using SOUBHAG.Model;

namespace SOUBHAG.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ba1300Controller : ControllerBase
    {
        private readonly Iba1300Service _ba1300Service;

        public ba1300Controller(Iba1300Service service)
        {
            _ba1300Service = service;
        }

        [HttpGet]
        [Route("LoadFind")]
        public ba1300Model LoadFind()
        {
            return _ba1300Service.LoadFind();
        }

    }
}
