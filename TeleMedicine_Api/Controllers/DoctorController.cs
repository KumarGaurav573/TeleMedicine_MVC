using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TeleMedicine_Api.Controllers
{
    [Authorize(Roles = "Admin,Reception")]
    public class DoctorController : ApiController
    {
        // GET api/Doctor
        public string Get()
        {
            return "Doctor..";
        }
    }
}
