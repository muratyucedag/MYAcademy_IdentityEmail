using Microsoft.AspNetCore.Mvc;

namespace MYAcademy_IdentityEmail.ViewComponents.MessageLayoutViewComponents
{
    public class _MessageLayoutScriptsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}