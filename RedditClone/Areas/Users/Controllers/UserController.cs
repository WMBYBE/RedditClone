using Microsoft.AspNetCore.Mvc;
using RedditClone.Models;

namespace RedditClone.Areas.Users.Controllers
{
    public class UserController : Controller
    {
        private ForumDbContext context { get; set; }

        public UserController(ForumDbContext ctx)
        {
            context = ctx;
        }
        public ActionResult Index(int id)
        {
            var posts = context.Posts
                    .Where(p => p.User.UserId == id)
                    .OrderBy(p => p.PostId);

            ViewBag.User = context.Users.Find(id);
            return View(posts.ToList());
        }

    }
}
