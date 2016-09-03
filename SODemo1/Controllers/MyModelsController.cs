using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SODemo1.Data;
using SODemo1.Models;

namespace SODemo1.Controllers
{
    public class MyModelsController : Controller
    {
        private readonly SODemoContext _db = new SODemoContext();

        // GET: MyModels
        public ActionResult Index()
        {
            return View(_db.MyModels.ToList());
        }

        // GET: MyModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyModel myModel = _db.MyModels.Find(id);
            if (myModel == null)
            {
                return HttpNotFound();
            }
            return View(myModel);
        }

        // GET: MyModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MyModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Text,Accepted,Description")] MyModel myModel)
        {
            if (ModelState.IsValid)
            {
                _db.MyModels.Add(myModel);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(myModel);
        }

        // GET: MyModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyModel myModel = _db.MyModels.Find(id);
            if (myModel == null)
            {
                return HttpNotFound();
            }
            return View(myModel);
        }

        // POST: MyModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Text,Accepted,Description")] MyModel myModel)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(myModel).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(myModel);
        }

        // GET: MyModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyModel myModel = _db.MyModels.Find(id);
            if (myModel == null)
            {
                return HttpNotFound();
            }
            return View(myModel);
        }

        // POST: MyModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MyModel myModel = _db.MyModels.Find(id);
            _db.MyModels.Remove(myModel);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
