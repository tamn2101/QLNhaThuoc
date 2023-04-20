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
    public class ThuocsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Thuocs
        public ActionResult Index()
        {
            var thuocs = db.Thuocs.Include(t => t.KhuVucLuuTru);
            return View(thuocs.ToList());
        }

        // GET: Thuocs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Thuoc thuoc = db.Thuocs.Find(id);
            if (thuoc == null)
            {
                return HttpNotFound();
            }
            return View(thuoc);
        }

        // GET: Thuocs/Create
        public ActionResult Create()
        {
            ViewBag.MaKhuVuc = new SelectList(db.KhuVucLuuTrus, "MaKhuVuc", "TenKhuVuc");
            return View();
        }

        // POST: Thuocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaThuoc,TenThuoc,Hinh,GiaBan,DonViTinh,MaKhuVuc,CongDung")] Thuoc thuoc)
        {
            if (ModelState.IsValid)
            {
                db.Thuocs.Add(thuoc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaKhuVuc = new SelectList(db.KhuVucLuuTrus, "MaKhuVuc", "TenKhuVuc", thuoc.MaKhuVuc);
            return View(thuoc);
        }

        // GET: Thuocs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Thuoc thuoc = db.Thuocs.Find(id);
            if (thuoc == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKhuVuc = new SelectList(db.KhuVucLuuTrus, "MaKhuVuc", "TenKhuVuc", thuoc.MaKhuVuc);
            return View(thuoc);
        }

        // POST: Thuocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaThuoc,TenThuoc,Hinh,GiaBan,DonViTinh,MaKhuVuc,CongDung")] Thuoc thuoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thuoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKhuVuc = new SelectList(db.KhuVucLuuTrus, "MaKhuVuc", "TenKhuVuc", thuoc.MaKhuVuc);
            return View(thuoc);
        }

        // GET: Thuocs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Thuoc thuoc = db.Thuocs.Find(id);
            if (thuoc == null)
            {
                return HttpNotFound();
            }
            return View(thuoc);
        }

        // POST: Thuocs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Thuoc thuoc = db.Thuocs.Find(id);
            db.Thuocs.Remove(thuoc);
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
