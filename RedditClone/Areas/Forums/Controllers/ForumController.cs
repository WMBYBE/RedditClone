using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RedditClone.Areas.Forums.Controllers
{
    public class ForumController : Controller
    {
        [Area("Forum")]
        public ActionResult Index()
        {
            return View();
        }

    }
}
