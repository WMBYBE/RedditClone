using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RedditClone.Models;

namespace RedditClone.Areas.Forums.Controllers
{
    [Area("Forums")]
    public class ForumController : Controller
    {
        private ForumDbContext context { get; set; }

        public ForumController(ForumDbContext ctx)
        {
            context = ctx;
        }

        public IActionResult index(int id)
        {
            List<Post> posts;
            {
                posts = context.Posts
                    .Where(p => p.Forum.ForumId == id)
                    .OrderBy(p => p.PostId).ToList();
            }

            return View(posts);
        }
    }
}
