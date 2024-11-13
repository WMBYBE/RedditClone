using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RedditClone.Areas.Forums.Controllers
{
    [Area("Forums")]
    public class ForumController : Controller
    {
        
        [Route("[action]/{id?}")]
        public ActionResult index(int id)
        {
            //PAGE 219                                                  
            id = 0;
            return View("Index");
        }

    }
}
