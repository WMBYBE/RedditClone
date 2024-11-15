using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RedditClone.Areas.Forums.Models;
using RedditClone.Models;
using System.Diagnostics;
using System.Linq;

namespace RedditClone.Controllers
{
    public class HomeController : Controller
    {
        private ForumDbContext context { get; set; }

        public HomeController(ForumDbContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var forums = context.Forums.OrderBy(c => c.Name).ToList();
            return View(forums);
        }

        public IActionResult ViewForum(int Forumid)
        {
            var posts = context.Posts
                .Include(f => f.Title)
                .OrderBy(f => f.ForumId);
            return View(posts);
        }
        }
}
