using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MYAcademy_IdentityEmail.Context;
using MYAcademy_IdentityEmail.Entities;

namespace MYAcademy_IdentityEmail.Controllers
{
    public class MessageController : Controller
    {
        private readonly EmailContext _context;
        private readonly UserManager<AppUser> _userManager;
        public MessageController(EmailContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Inbox()
        {
            var values = _context.Messages.ToList();
            return View(values);
        }

        public async Task<IActionResult> Sendbox()
        {
            var value = await _userManager.GetUserAsync(User);

            var messageList = _context.Messages.Where(x => x.SenderEmail == value.Email).ToList();

            return View(messageList);
        }

        public IActionResult CreateMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(Message message)
        {
            var values = await _userManager.GetUserAsync(User);

            message.SendDate= DateTime.Now;
            message.SenderEmail = values.Email;
            message.IsRead = false;
            message.CategoryId = 1;
            _context.Messages.Add(message);

            _context.SaveChanges();
            return RedirectToAction("Sendbox");

        }
    }
}
