using Microsoft.AspNetCore.Mvc;
using RedditClone.Areas.Forums.Models;
using RedditClone.Models;
using System.Diagnostics;

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
            var forums = context.Forums
                .OrderBy(forum => forum.Name)
                .ToList();
            return View(forums);
        }
        public IActionResult forums(string id)
        {
            return Content("ForumController, List action, Category: " + id);
        }
    }
}