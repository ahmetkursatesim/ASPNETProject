using System.Web.Mvc;

namespace Myproject.Web.Controllers
{
    public class AboutController : MyprojectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}