using TeleMedicine_Models.Models.Response;

namespace TeleMedicine_Api.DAL.Interfaces
{
    public interface IAuthenticateRepository
    {
        string TestAuthntication(string userName, string password);
        AuthenticateResponse GetUserDetailsByCredientials(string userName, string password);
    }
}
