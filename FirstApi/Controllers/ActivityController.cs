using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstApi.Controllers
{
    public class ActivityController : ApiController
    {

        public string Get()
        {
            return "ça marche!";
        }

        public string Post()
        {
            return "ça marche aussi!";
        }
    }
}
