using Myproject.UserPhotos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Myproject.Web.Areas.UserPhoto.Controllers
{
    public class UserPhotoController : Controller
    {



        private readonly IUserPhotoAppService _userPhotoAppService;
   





        public UserPhotoController(UserPhotoAppService userPhotoAppService)
        {
            _userPhotoAppService = userPhotoAppService;
      

        }
        // GET: UserPhoto/UserPhoto
        public ActionResult Index()
        {

            var output = _userPhotoAppService.ListAll();


            return View(output);
        }

        // GET: UserPhoto/UserPhoto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserPhoto/UserPhoto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserPhoto/UserPhoto/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserPhoto/UserPhoto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserPhoto/UserPhoto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserPhoto/UserPhoto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserPhoto/UserPhoto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
