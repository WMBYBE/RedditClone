using Microsoft.AspNetCore.Mvc;
using RedditClone.Areas.Forums.Controllers;
using RedditClone.Models;

namespace RedditClone.Areas.Forums.Controllers
{
    [Area("Forums")]
    public class PostController : Controller
    {

        private ForumDbContext context { get; set; }

        public PostController(ForumDbContext ctx)
        {
            context = ctx;
        }

        public IActionResult Post(int id)
        {
            Post post = context.Posts.Find(id);

            return View(post);
        }
    }
}