using Microsoft.AspNetCore.Mvc;
using RedditClone.Models;
using System.Diagnostics;

namespace RedditClone.Areas.Forums.Controllers
{
    [Area("Forum"]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
