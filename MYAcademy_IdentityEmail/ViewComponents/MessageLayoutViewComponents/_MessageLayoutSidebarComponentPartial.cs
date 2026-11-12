using Microsoft.AspNetCore.Mvc;

namespace MYAcademy_IdentityEmail.ViewComponents.MessageLayoutViewComponents
{
    public class _MessageLayoutSidebarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
