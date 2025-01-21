using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Controllers
{
    public class ContactController : Controller
    {

        private readonly IMessageService _messageService;

        public ContactController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult ContactSendMessagePartial()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult ContactSendMessagePartial(Message message)
        {
            _messageService.TInsert(message);
            return RedirectToAction("Index");
        }
    }
}
