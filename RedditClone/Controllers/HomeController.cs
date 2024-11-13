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
            var forum = context.Forums.OrderBy(c => c.Name).ToList();
            return View(forum);
        }
        //[Route("Forums/[controller]/[action]/[id]")]
        public IActionResult forums(string id)
        {
            return Content("ForumController, List action, Category: " + id);
        }
        [Area("Forums")]
        public ActionResult Forum(int id)
        {
             //  PAGE 219;
            return View("~/Areas/Forums/Views/Index");
        }
    }
}
