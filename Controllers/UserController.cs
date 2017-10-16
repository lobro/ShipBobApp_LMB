using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShipBobApp_LMB.Models;

namespace ShipBobApp_LMB.Controllers
{
    public class UserController : Controller
    {
        private static Users _users = new Users();

        /// <summary>
        /// Index this instance.
        /// </summary>
        /// <returns>The index.</returns>
        public ActionResult Index()
        {
            //@ViewBag.Title = "Users";
            //return View(_users._userLists);
            return View();
        }

        public ActionResult AddEdit()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}