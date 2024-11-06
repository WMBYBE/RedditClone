using Microsoft.AspNetCore.Mvc;
using RedditClone.Areas.Forums.Models;
using RedditClone.Models;
using System.Diagnostics;

namespace RedditClone.Controllers
{
    public class HomeController : Controller
    {

        private ForumDbContext context { get; set; }

        public HomeController(ForumDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var characters = context.Forums.OrderBy(c => c.Name).ToList();
            return View(characters);
        }


        //[Route("Forums/[controller]/[action]/[id]")]
        public IActionResult forums(string id)
        {
            return Content("ForumController, List action, Category: " + id);
        }
    }
}
