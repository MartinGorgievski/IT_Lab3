using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IT_Lab3.Models;
namespace IT_Lab3.Controllers
{
    public class FriendController : Controller
    {
        private FriendDB db = new FriendDB();
        // GET: Friend
        public ActionResult ListAll()
        {
            var items = db.FriendModels.ToList();

            return View(items);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include= "FriendID, Ime, MestoNaZiveenje")] FriendModel friend)
        {
            if (ModelState.IsValid)
            {
                db.FriendModels.Add(friend);
                db.SaveChanges();
                return RedirectToAction("ListAll");
            }
            else
            {
                return RedirectToAction("Create");
            } 
        }

        public ActionResult Edit(int? id)
        {
            var item = db.FriendModels.Find(id);

            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID, FriendID, Ime, MestoNaZiveenje")] FriendModel friend)
        {
            if (ModelState.IsValid)
            {
                db.Entry(friend).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            return RedirectToAction("ListAll");
        }

        public ActionResult Delete(int? id)
        {
            return View(db.FriendModels.Find(id));
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            if(id != null)
            {
                FriendModel friend = db.FriendModels.Find(id);
                db.FriendModels.Remove(friend);
                db.SaveChanges();

            }
            return RedirectToAction("ListAll");
        }
    }
}