using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        [HttpPost]
        public IActionResult Index(string searchString)
        {

            var forums = from m in context.Forums
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                forums = forums.Where(s => s.Name!.ToUpper().Contains(searchString.ToUpper()));
            }

            return View(forums.ToList());
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
