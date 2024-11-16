using Microsoft.AspNetCore.Mvc;
using RedditClone.Areas.Forums.Controllers;
using RedditClone.Areas.Forums.Models;
using RedditClone.Models;

namespace RedditClone.Areas.Forums.Controllers
{
    [Area("Forums")]
    public class PostController : Controller
    {

        private ForumDbContext context { get; set; }

        public PostController(ForumDbContext ctx)
        {
            context = ctx;
        }

        public IActionResult Post(int id)
        {
            Post post = context.Posts.Find(id);

            List<Comment> comments;
            {
                comments = context.Comments
                    .Where(p => p.Post.PostId == id)
                    .OrderBy(p => p.CommentId).ToList();
            }

            ViewBag.Comments = comments;

            return View(post);
        }
    }
}