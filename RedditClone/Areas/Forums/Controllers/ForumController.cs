using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        [Route("[action]/{id?}")]
        public ActionResult index(int id)
        {
            //PAGE 219                                                  
            var forum = context.Posts.OrderBy(c => c.PostId).ToList();
            return View(forum);

        }

    }
}
