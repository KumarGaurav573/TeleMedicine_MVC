using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeleMedicine_Api.BLL.Interfaces;

namespace TeleMedicine_Api.Controllers
{
    [Authorize(Roles = "Admin,Reception")]
    public class ReceptionController : ApiController
    {
        private readonly IReceptionBS _reception;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public ReceptionController(IReceptionBS receptionBS)
        {
            if (_reception == null)
            {
                LogManager.Configuration.Variables["ControllerName"] = "ReceptionController";
                logger.Info("Reception controller init........");
                _reception = receptionBS;
            }
        }
        // GET api/values
        public string Get()
        {
            logger.Info("Test Reception function.....");
            return _reception.TestReception();
        }
    }
}
