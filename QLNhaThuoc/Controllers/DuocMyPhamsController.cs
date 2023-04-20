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
    public class DuocMyPhamsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: DuocMyPhams
        public ActionResult Index()
        {
            var duocMyPhams = db.DuocMyPhams.Include(d => d.KhuVucLuuTru);
            return View(duocMyPhams.ToList());
        }

        // GET: DuocMyPhams/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DuocMyPham duocMyPham = db.DuocMyPhams.Find(id);
            if (duocMyPham == null)
            {
                return HttpNotFound();
            }
            return View(duocMyPham);
        }

        // GET: DuocMyPhams/Create
        [Authorize(Roles ="admin")]
        public ActionResult Create()
        {
            ViewBag.MaKhuVuc = new SelectList(db.KhuVucLuuTrus, "MaKhuVuc", "TenKhuVuc");
            return View();
        }

        // POST: DuocMyPhams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaDMP,TenDMP,Hinh,GiaBan,DonViTinh,MaKhuVuc,XuatXu,CongDung")] DuocMyPham duocMyPham)
        {
            if (ModelState.IsValid)
            {
                db.DuocMyPhams.Add(duocMyPham);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaKhuVuc = new SelectList(db.KhuVucLuuTrus, "MaKhuVuc", "TenKhuVuc", duocMyPham.MaKhuVuc);
            return View(duocMyPham);
        }

        // GET: DuocMyPhams/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DuocMyPham duocMyPham = db.DuocMyPhams.Find(id);
            if (duocMyPham == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKhuVuc = new SelectList(db.KhuVucLuuTrus, "MaKhuVuc", "TenKhuVuc", duocMyPham.MaKhuVuc);
            return View(duocMyPham);
        }

        // POST: DuocMyPhams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaDMP,TenDMP,Hinh,GiaBan,DonViTinh,MaKhuVuc,XuatXu,CongDung")] DuocMyPham duocMyPham)
        {
            if (ModelState.IsValid)
            {
                db.Entry(duocMyPham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKhuVuc = new SelectList(db.KhuVucLuuTrus, "MaKhuVuc", "TenKhuVuc", duocMyPham.MaKhuVuc);
            return View(duocMyPham);
        }

        // GET: DuocMyPhams/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DuocMyPham duocMyPham = db.DuocMyPhams.Find(id);
            if (duocMyPham == null)
            {
                return HttpNotFound();
            }
            return View(duocMyPham);
        }

        // POST: DuocMyPhams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DuocMyPham duocMyPham = db.DuocMyPhams.Find(id);
            db.DuocMyPhams.Remove(duocMyPham);
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
