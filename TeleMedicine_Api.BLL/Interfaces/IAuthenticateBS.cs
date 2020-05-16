using TeleMedicine_Models.Models.Response;

namespace TeleMedicine_Api.BLL.Interfaces
{
    public interface IAuthenticateBS
    {
        string TestAuthntication(string userName, string password);
        AuthenticateResponse GetUserDetailsByCredientials(string userName, string password);
    }
}
