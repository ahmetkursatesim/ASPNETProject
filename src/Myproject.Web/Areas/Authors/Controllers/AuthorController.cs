using Myproject.Authors;
using Myproject.Authors.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Myproject.Web.Areas.Authors.Controllers
{
    public class AuthorController : Controller
    {

        private readonly IAuthorAppService _authorAppService;


        public AuthorController(IAuthorAppService authorAppService)
        {
            _authorAppService = authorAppService;

        }

        // GET: Authors/Author
        public ActionResult Index()
        {
             var output = _authorAppService.ListAll();
       
            return View(output);
           
        }

    
      

        





    }
}

