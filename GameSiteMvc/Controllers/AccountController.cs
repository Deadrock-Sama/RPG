using Microsoft.AspNetCore.Mvc;

namespace GameSiteMvc.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
