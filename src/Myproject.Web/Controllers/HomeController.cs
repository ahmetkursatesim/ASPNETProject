using System.Web.Mvc;
using Abp.Net.Mail;
using Abp.Net.Mail.Smtp;
using Abp.Web.Mvc.Authorization;
using Myproject.Configuration;


namespace Myproject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MyprojectControllerBase
    {


        public ActionResult Index()
        {
           
            return View();
        }
	}
}