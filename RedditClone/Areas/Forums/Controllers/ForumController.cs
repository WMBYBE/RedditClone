using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RedditClone.Models;

namespace RedditClone.Areas.Forums.Controllers
{
    [Area("Forums")]
    public class ForumController : Controller
    {
        private ForumDbContext context { get; set; }

        public ForumController(ForumDbContext ctx)
        {
            context = ctx;
        }

        public ActionResult Index(string sortOrder, int id)
        {
            var forumList = context.Forums
                .OrderBy(c => c.ForumId).ToList(); 

            ViewBag.NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            var posts = context.Posts
                    .Where(p => p.Forum.ForumId == id)
                    .OrderBy(p => p.PostId);
            posts = sortOrder switch
            {
                "name_desc" => posts.OrderByDescending(s => s.Title),
                "Date" => posts.OrderBy(s => s.Date),
                "date_desc" => posts.OrderByDescending(s => s.Date),
                _ => posts.OrderBy(s => s.Title),

            };
            ViewBag.ForumName = context.Forums.Find(id);
            ViewBag.ForumList = forumList;
            return View(posts.ToList());
        }
    }
}
