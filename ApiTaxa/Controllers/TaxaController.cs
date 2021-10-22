using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiTaxa.Controllers
{
    [RoutePrefix("api/ws")]
    public class TaxaController : ApiController
    {
        [HttpGet]
        [Route("taxaJuros")]
        public object RetornarTaxa()
        {
            object taxa = new { valorTaxa = 0.01D };
            return taxa;
        }
        
    }
}