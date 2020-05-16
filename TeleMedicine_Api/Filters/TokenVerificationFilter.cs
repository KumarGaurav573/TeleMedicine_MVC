using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using TeleMedicine_Api.Models;
namespace TeleMedicine_Api.Filters
{
    public class TokenVerificationFilter : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Contains("Token"))
            {
                Token tokenservice = new Token();
                string tokenValue = actionContext.Request.Headers.GetValues("Token").First();
                tokenservice.CleanUp();
                string User = tokenservice.Extend(Guid.Parse(tokenValue));
                if (User == string.Empty)
                    actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);

            }
            else
            {
                actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
            }
            base.OnAuthorization(actionContext);
        }
    }
}