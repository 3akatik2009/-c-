using Microsoft.AspNetCore.Mvc;

namespace Сайт_на_c_.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
