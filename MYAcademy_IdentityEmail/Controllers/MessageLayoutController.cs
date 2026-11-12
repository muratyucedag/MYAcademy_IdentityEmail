using Microsoft.AspNetCore.Mvc;

namespace MYAcademy_IdentityEmail.Controllers
{
    public class MessageLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
