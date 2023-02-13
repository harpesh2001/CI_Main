using Microsoft.AspNetCore.Mvc;

namespace CI_Platform.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return PartialView();
        }
        
        public IActionResult ForgotPassword()
        {
            return PartialView();
        }
        public IActionResult ResetPassword()
        {
            return PartialView();
        }
        public IActionResult Register()
        {
            return PartialView();
        }
    }
}
