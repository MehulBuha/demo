using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticalDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(tbl_user2 objuser)
        {
            PracticalDemoEntities2 db = new PracticalDemoEntities2();
           var user= db.tbl_user2.Where(x => x.UserName == objuser.UserName && x.Email == objuser.Email).Count();
            if(user>0)
            {
                return RedirectToAction("ListUsers");
            }
            else
            {
                return View();
            }
           
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Register(tbl_user2 user)
        {

            PracticalDemoEntities2 db = new PracticalDemoEntities2();
            db.tbl_user2.Add(user);
            db.SaveChanges();
            return RedirectToAction("ListUsers");
        }

        public ActionResult ListUsers()
        {
            PracticalDemoEntities2 db = new PracticalDemoEntities2();
            var users = db.tbl_user2.ToList();
            return View(users);
        }

        public ActionResult UserProfile(int id)
        {
            PracticalDemoEntities2 db = new PracticalDemoEntities2();

            var user = db.tbl_user2.Find(id);
            return View(user);
        }

        [HttpPost]
        public ActionResult UserProfile(tbl_user2 objuser)
        {
            PracticalDemoEntities2 db = new PracticalDemoEntities2();
            db.Entry(objuser).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return View();
        }
    }
}