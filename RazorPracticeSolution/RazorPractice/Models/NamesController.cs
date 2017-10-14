using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorPractice.Models
{
    public class NamesController : Controller
    {
        List<Person> nameList = new List<Person>()
        {
            new Person(){Name = "Sarah" },
            new Person(){Name = "Mark" },
            new Person(){Name = "Veronica" }

        };
        // GET: Names
        public ActionResult Index()
        {
            var Names = nameList.ToList();
            return View(Names);
        }

        // GET: Names/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Names/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Names/Create
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

        // GET: Names/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Names/Edit/5
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

        // GET: Names/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Names/Delete/5
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
