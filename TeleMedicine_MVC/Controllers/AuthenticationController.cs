using System.Web.Mvc;
using TeleMedicine_Api.Controllers;

namespace TeleMedicine_MVC.Controllers
{
    public class AuthenticationController : Controller
    {
        // private readonly AuthenticateController _authenticateApi;
        // public AuthenticationController(AuthenticateController authenticateController)
        // {
         //    if (_authenticateApi == null)
         //    {
         //        _authenticateApi = authenticateController;
         //    }
       //  }

        // GET: Authentication
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetUserByCredientials(string userName, string password)
        {
            return Json("Surya", JsonRequestBehavior.AllowGet);
        }
    }
}