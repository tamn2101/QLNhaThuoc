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
    public class ThucPhamChucNangsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ThucPhamChucNangs
        public ActionResult Index()
        {
            var thucPhamChucNangs = db.ThucPhamChucNangs.Include(t => t.KhuVucLuuTru);
            return View(thucPhamChucNangs.ToList());
        }

        // GET: ThucPhamChucNangs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThucPhamChucNang thucPhamChucNang = db.ThucPhamChucNangs.Find(id);
            if (thucPhamChucNang == null)
            {
                return HttpNotFound();
            }
            return View(thucPhamChucNang);
        }

        // GET: ThucPhamChucNangs/Create
        public ActionResult Create()
        {
            ViewBag.MaKhuVuc = new SelectList(db.KhuVucLuuTrus, "MaKhuVuc", "TenKhuVuc");
            return View();
        }

        // POST: ThucPhamChucNangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaThucPham,TenThucPham,Hinh,GiaBan,DonViTinh,MaKhuVuc,XuatXu,CongDung")] ThucPhamChucNang thucPhamChucNang)
        {
            if (ModelState.IsValid)
            {
                db.ThucPhamChucNangs.Add(thucPhamChucNang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaKhuVuc = new SelectList(db.KhuVucLuuTrus, "MaKhuVuc", "TenKhuVuc", thucPhamChucNang.MaKhuVuc);
            return View(thucPhamChucNang);
        }

        // GET: ThucPhamChucNangs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThucPhamChucNang thucPhamChucNang = db.ThucPhamChucNangs.Find(id);
            if (thucPhamChucNang == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKhuVuc = new SelectList(db.KhuVucLuuTrus, "MaKhuVuc", "TenKhuVuc", thucPhamChucNang.MaKhuVuc);
            return View(thucPhamChucNang);
        }

        // POST: ThucPhamChucNangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaThucPham,TenThucPham,Hinh,GiaBan,DonViTinh,MaKhuVuc,XuatXu,CongDung")] ThucPhamChucNang thucPhamChucNang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thucPhamChucNang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKhuVuc = new SelectList(db.KhuVucLuuTrus, "MaKhuVuc", "TenKhuVuc", thucPhamChucNang.MaKhuVuc);
            return View(thucPhamChucNang);
        }

        // GET: ThucPhamChucNangs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThucPhamChucNang thucPhamChucNang = db.ThucPhamChucNangs.Find(id);
            if (thucPhamChucNang == null)
            {
                return HttpNotFound();
            }
            return View(thucPhamChucNang);
        }

        // POST: ThucPhamChucNangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ThucPhamChucNang thucPhamChucNang = db.ThucPhamChucNangs.Find(id);
            db.ThucPhamChucNangs.Remove(thucPhamChucNang);
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
