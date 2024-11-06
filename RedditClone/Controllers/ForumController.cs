using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RedditClone.Controllers
{
    public class ForumController : Controller
    {
        // GET: ForumController
        public ActionResult Index()
        {
            return View();
        }

    }
}
