using Microsoft.AspNetCore.Mvc;

namespace WEBAPI_STAJ.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            string errorMessage = "Üzgünüm, bir hata oluştu.";

            ViewData["ErrorMessage"] = errorMessage;

            return View("Index");
        }
    }
}
