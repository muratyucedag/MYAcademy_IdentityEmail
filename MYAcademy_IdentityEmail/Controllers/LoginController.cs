using Microsoft.AspNetCore.Mvc;

namespace MYAcademy_IdentityEmail.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
