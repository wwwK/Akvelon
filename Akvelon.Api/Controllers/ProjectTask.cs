using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Akvelon.Api.Controllers
{
    public class ProjectTask : Controller
    {
        // GET: ProjectTask
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProjectTask/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProjectTask/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjectTask/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProjectTask/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProjectTask/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProjectTask/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProjectTask/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
