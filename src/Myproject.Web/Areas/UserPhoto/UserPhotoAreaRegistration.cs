using System.Web.Mvc;

namespace Myproject.Web.Areas.UserPhoto
{
    public class UserPhotoAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "UserPhoto";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "UserPhoto_default",
                "UserPhoto/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}