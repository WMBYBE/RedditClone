using Microsoft.AspNetCore.Mvc;
using RedditClone.Models;
using System.Diagnostics;

namespace RedditClone.Areas.Posts.Controllers
{
    [Area("Posts")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
