using Microsoft.AspNetCore.Mvc;
using RedditClone.Areas.Forums.Controllers;
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
        [HttpGet]
        public IActionResult add()
        {
            ViewBag.Action = "Add";
            ViewBag.Forums = context.Forums.OrderBy(g => g.Name).ToList();
            return View("Add", new Post());
        }
        [HttpGet]
        public IActionResult addComment()
        {
            ViewBag.Action = "Add";
            ViewBag.Posts = context.Posts.OrderBy(g => g.Title).ToList();
            return View("AddComment", new Comment());
        }
        [HttpPost]
        public IActionResult add(Post post)
        {
            if (ModelState.IsValid)
            {
                if (post.PostId == 0)
                    context.Posts.Add(post);
                else
                    context.Posts.Update(post);
                context.SaveChanges();
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            else
            {
                ViewBag.Action = (post.PostId == 0) ? "Add" : "Edit";
                ViewBag.Forums = context.Forums.OrderBy(g => g.Name).ToList();
                return View(post);
            }
        }
        [HttpPost]
        public IActionResult addComment(Comment comment)
        {
            if (ModelState.IsValid)
            {
                if (comment.CommentId == 0)
                    context.Comments.Add(comment);
                else
                    context.Comments.Update(comment);
                context.SaveChanges();
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            else
            {
                ViewBag.Action = (comment.CommentId == 0) ? "AddComment" : "Edit";
                ViewBag.Posts = context.Posts.OrderBy(g => g.Title).ToList();
                return View(comment);
            }
        }
        [HttpGet]
        public IActionResult DeletePost(int id)
        {
            var post = context.Posts.Find(id);
            return View(post);
        }

        [HttpPost]
        public IActionResult DeletePost(Post post)
        {
            context.Posts.Remove(post);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}