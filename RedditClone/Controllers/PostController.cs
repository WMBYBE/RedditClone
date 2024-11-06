using Microsoft.AspNetCore.Mvc;

namespace RedditClone.Area.Post.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
