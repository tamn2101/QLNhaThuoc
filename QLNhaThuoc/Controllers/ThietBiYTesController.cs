using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QLNhaThuoc.Models;

namespace QLNhaThuoc.Controllers
{
    public class ThietBiYTesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ThietBiYTes
        public ActionResult Index()
        {
            var thietBiYTes = db.ThietBiYTes.Include(t => t.KhuVucLuuTru);
            return View(thietBiYTes.ToList());
        }

        // GET: ThietBiYTes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThietBiYTe thietBiYTe = db.ThietBiYTes.Find(id);
            if (thietBiYTe == null)
            {
                return HttpNotFound();
            }
            return View(thietBiYTe);
        }

        // GET: ThietBiYTes/Create
        public ActionResult Create()
        {
            ViewBag.MaKhuVuc = new SelectList(db.KhuVucLuuTrus, "MaKhuVuc", "TenKhuVuc");
            return View();
        }

        // POST: ThietBiYTes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaThietBi,TenThietBi,Hinh,GiaBan,DonViTinh,MaKhuVuc,XuatXu,CongDung")] ThietBiYTe thietBiYTe)
        {
            if (ModelState.IsValid)
            {
                db.ThietBiYTes.Add(thietBiYTe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaKhuVuc = new SelectList(db.KhuVucLuuTrus, "MaKhuVuc", "TenKhuVuc", thietBiYTe.MaKhuVuc);
            return View(thietBiYTe);
        }

        // GET: ThietBiYTes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThietBiYTe thietBiYTe = db.ThietBiYTes.Find(id);
            if (thietBiYTe == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKhuVuc = new SelectList(db.KhuVucLuuTrus, "MaKhuVuc", "TenKhuVuc", thietBiYTe.MaKhuVuc);
            return View(thietBiYTe);
        }

        // POST: ThietBiYTes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaThietBi,TenThietBi,Hinh,GiaBan,DonViTinh,MaKhuVuc,XuatXu,CongDung")] ThietBiYTe thietBiYTe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thietBiYTe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKhuVuc = new SelectList(db.KhuVucLuuTrus, "MaKhuVuc", "TenKhuVuc", thietBiYTe.MaKhuVuc);
            return View(thietBiYTe);
        }

        // GET: ThietBiYTes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThietBiYTe thietBiYTe = db.ThietBiYTes.Find(id);
            if (thietBiYTe == null)
            {
                return HttpNotFound();
            }
            return View(thietBiYTe);
        }

        // POST: ThietBiYTes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ThietBiYTe thietBiYTe = db.ThietBiYTes.Find(id);
            db.ThietBiYTes.Remove(thietBiYTe);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
