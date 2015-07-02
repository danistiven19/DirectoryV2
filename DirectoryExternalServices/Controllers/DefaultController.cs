using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DirectoryExternalServices.Controllers
{
    public class DefaultController : ApiController
    {
        public String GetAllDefault()
        {
            return "Hola";
        }
    }
}
