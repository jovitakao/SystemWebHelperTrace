using HelperSample;
using System.Web.Mvc;

namespace MVCSample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.SHA1 = Signature.Get("Bruce");
            return View();
        }
    }
}