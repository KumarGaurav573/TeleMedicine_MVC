using TeleMedicine_Api.DAL.Interfaces;
using TeleMedicine_Models.Models.Response;

namespace TeleMedicine_Api.DAL.Repositories
{
    public class AuthenticateRepository : IAuthenticateRepository
    {
        public string TestAuthntication(string userName, string password)
        {
            return userName + "--" + password;
        }
        public AuthenticateResponse GetUserDetailsByCredientials(string userName, string password)
        {
            AuthenticateResponse response = new AuthenticateResponse();
            if (userName == "Ashok")
            {
                response.UserId = 1;
                response.UserName = userName;
                response.RoleId = 1;
                response.RoleName = "Doctor";
            }
            if (userName == "Surya")
            {
                response.UserId = 1;
                response.UserName = userName;
                response.RoleId = 2;
                response.RoleName = "Reception";
            }
            if (userName == "Prakash")
            {
                response.UserId = 1;
                response.UserName = userName;
                response.RoleId = 3;
                response.RoleName = "Pharmacy ";
            }
            return response;
        }
    }
}
