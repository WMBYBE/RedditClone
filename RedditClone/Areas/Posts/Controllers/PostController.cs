using Microsoft.AspNetCore.Mvc;

namespace RedditClone.Controllers
{
    public class PostController : Controller
    {
        [Area("Posts")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
