using Microsoft.AspNetCore.Mvc;
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
            var forums= context.Forums
                .ToList();
            return View(forums);
        }
        
        [Route("forums/[controller]/[action]/[id]")]
        public IActionResult forums(string id)
        {
            return Content("ForumController, List action, Category: " + id);
        }
    }
}
