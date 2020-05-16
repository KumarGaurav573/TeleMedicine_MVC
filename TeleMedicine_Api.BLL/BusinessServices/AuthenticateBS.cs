using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleMedicine_Api.BLL.Interfaces;
using TeleMedicine_Api.DAL.Interfaces;
using TeleMedicine_Models.Models.Response;

namespace TeleMedicine_Api.BLL.BusinessServices
{
    public class AuthenticateBS : IAuthenticateBS
    {
        private readonly IAuthenticateRepository _authenticate;
        public AuthenticateBS(IAuthenticateRepository authenticateRepository)
        {
            if (_authenticate == null)
            {
                _authenticate = authenticateRepository;
            }
        }
        public string TestAuthntication(string userName, string password)
        {
            return _authenticate.TestAuthntication(userName, password);
        }
        public AuthenticateResponse GetUserDetailsByCredientials(string userName, string password)
        {
            return _authenticate.GetUserDetailsByCredientials(userName, password);
        }
    }
}
