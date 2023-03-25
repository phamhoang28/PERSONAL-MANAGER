using BTL_QLNS3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTL_QLNS3.Controllers
{
    public class PhongBanController : Controller
    {
        // GET: PhongBan
        public ActionResult Index()
        {
            var listPhongBan = new DBContext().PHONGBANs.ToList();
            return View(listPhongBan);
        }

        // GET: PhongBan/Details/5
        public ActionResult Details(string id_Pb)
        {
            return View();
        }

        // GET: PhongBan/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PhongBan/Create
        [HttpPost]
        public ActionResult Create(PHONGBAN model)
        {
            try
            {
                // TODO: Add insert logic here
                var context = new DBContext();
                context.PHONGBANs.Add(model);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PhongBan/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PhongBan/Edit/5
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

        // GET: PhongBan/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PhongBan/Delete/5
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
