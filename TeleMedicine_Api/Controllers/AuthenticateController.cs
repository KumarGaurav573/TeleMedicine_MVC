using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeleMedicine_Api.BLL.Interfaces;
using TeleMedicine_Models.Models.Response;

namespace TeleMedicine_Api.Controllers
{
    public class AuthenticateController : ApiController
    {
        private readonly IAuthenticateBS _authenticate;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public AuthenticateController(IAuthenticateBS authenticateBS)
        {
            if (_authenticate == null)
            {
                LogManager.Configuration.Variables["ControllerName"] = "AuthenticateController";
                logger.Info("Authenticate controller init........");
                _authenticate = authenticateBS;
            }
        }

        public AuthenticateResponse GetUserAuthentication(string userName, string password)
        {
            logger.Info(string.Format("ActionName:GetUserAuthentication, UserName:{0}, Password:{1}", userName, password));
            return _authenticate.GetUserDetailsByCredientials(userName, password);
        }

    }
}
