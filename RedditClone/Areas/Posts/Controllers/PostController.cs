using Microsoft.AspNetCore.Mvc;

namespace RedditClone.Controllers
{
    [Area("Posts")]
    public class PostController : Controller
    {
        
        public IActionResult Index(int postid, int forumid)
        {
            return View("Post");
        }
    }
}
