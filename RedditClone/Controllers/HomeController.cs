using Microsoft.AspNetCore.Mvc;
using RedditClone.Models;
using System.Diagnostics;

namespace RedditClone.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var forums = context.Forums
                .OrderBy(forum => forum.Name)
                .ToList();
            return View(forums);
        }
<<<<<<< Updated upstream

=======
        public IActionResult forums(string id)
        {
            return Content("ForumController, List action, Category: " + id);
        }
>>>>>>> Stashed changes
    }
}
