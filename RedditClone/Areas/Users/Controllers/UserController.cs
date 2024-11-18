using Microsoft.AspNetCore.Mvc;

namespace RedditClone.Areas.Users.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
