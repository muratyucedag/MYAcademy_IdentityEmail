using Microsoft.AspNetCore.Mvc;

namespace MYAcademy_IdentityEmail.ViewComponents.MessageLayoutViewComponents
{
    public class _MessageLayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}