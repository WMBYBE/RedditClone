using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
            var forums = context.Forums.OrderBy(c => c.Name).ToList(); //Sends the lsit of forums to the index page so that you can see them all
            
            List<Post> posts;
            {
                posts = context.Posts
                    .OrderBy(p => p.Date).ToList(); //sorts posts by date
            }
            var topPosts = posts.Take(3); //limits the posts to show to the top 3

            ViewBag.TopPosts = topPosts;

            return View(forums);
        }
        [HttpPost]
        public IActionResult Index(string searchString) //allows searching 
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
