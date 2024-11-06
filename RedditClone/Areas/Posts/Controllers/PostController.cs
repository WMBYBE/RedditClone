using Microsoft.AspNetCore.Mvc;

namespace RedditClone.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
