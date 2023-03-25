using BTL_QLNS3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTL_QLNS3.Controllers
{
    public class NhanVienController : Controller
    {
        // GET: NhanVien
        public ActionResult Index()
        {
            var listNhanVien=new DBContext().NHANVIENs.ToList();
            return View(listNhanVien);
        }

        // GET: NhanVien/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NhanVien/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhanVien/Create
        [HttpPost]
        public ActionResult Create(NHANVIEN model)
        {
            try
            {
                // TODO: Add insert logic here
                var context = new DBContext();
                context.NHANVIENs.Add(model);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVien/Edit/5
        public ActionResult Edit(string id_Nv)
        {
            var context=new DBContext();
            var editing = context.NHANVIENs.Find(id_Nv);
            ViewBag.id_Nv1 = id_Nv;
            return View(editing);
        }

        // POST: NhanVien/Edit/5
        [HttpPost]
        public ActionResult Edit(NHANVIEN model)
        {
            try
            {
                // TODO: Add update logic here
                var context = new DBContext();
                var oldItem = context.NHANVIENs.Find(model.name_Nv);
                oldItem.luong_Nv = model.luong_Nv;
                oldItem.diachi_Nv = model.diachi_Nv;
                oldItem.id_Pb = model.id_Pb;
                oldItem.id_Da = model.id_Da;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVien/Delete/5
        public ActionResult Delete(string id_Nv)
        {
            var context = new DBContext();
            var delete = context.NHANVIENs.Find(id_Nv);

            return View(delete);
        }

        // POST: NhanVien/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var context = new DBContext();
                 var delete = context.NHANVIENs.Find(id);
                context.NHANVIENs.Remove(delete);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
