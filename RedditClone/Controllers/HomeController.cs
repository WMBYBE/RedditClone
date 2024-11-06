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
            return View();
        }
        [Route("Forums/[controller]/[action]/[id]")]
        public IActionResult forums(string id)
        {
            return Content("ForumController, List action, Category: " + id);
        }
    }
}
