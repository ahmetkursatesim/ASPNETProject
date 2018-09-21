using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Myproject.Authors;
using Myproject.Authors.DTO;
using Myproject.Authors.Manager;
using Myproject.Book.Manager;
using Myproject.Books;
using Myproject.Books.DTO;
using Myproject.Web.Areas.Books.Models;
using Myproject.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Myproject.Web.Areas.Books.Controllers
{
    public class BookController : MyprojectControllerBase
    {

        // GET: Book

        private readonly IBookAppService _bookAppService;
        private readonly IRepository<Author> _repositoryAuthor;





        public BookController(IBookAppService bookAppService, IRepository<Author> repositoryAuthor)
        {
            _bookAppService = bookAppService;
            _repositoryAuthor = repositoryAuthor;
           
        }
        public async Task<ActionResult> Index()
        {

            List<Author> list = new List<Author>();

            var output =  _bookAppService.ListAll();

            var ty = _repositoryAuthor.GetAll().ToList();
            foreach (var t in ty)
            {


                list.Add(t);
               


            }

            ViewBag.refauthor = list;

            return View(output);
          



           
        }
       







    }
}
