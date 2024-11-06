using Microsoft.AspNetCore.Mvc;
using RedditClone.Models;
using System.Diagnostics;

namespace RedditClone.Controllers
{
    public class HomeController : Controller
    {
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
