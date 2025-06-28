using Microsoft.AspNetCore.Mvc;
using Сайт_на_c_.Models;

namespace Сайт_на_c_.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Check(Contact contact)
        {
            if (ModelState.IsValid)
            {
                return Redirect("/");
            }
            return View("Index");
        }
    }
}
