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
        public IActionResult ViewForum(int Forumid)
        {
            var posts = context.Posts
                .Include(f => f.Title)
                .OrderBy(f => f.ForumId == Forumid).ToList();
            return View(posts);
        }
    }
}
