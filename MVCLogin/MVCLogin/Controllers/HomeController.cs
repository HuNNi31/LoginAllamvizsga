using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MVCLogin.Models;

namespace MVCLogin.Controllers
{
    
    public class HomeController : Controller
    {
        MyDataBaseEntitiess db = new MyDataBaseEntitiess();
        //
        // GET: /Home/
        public ActionResult Index()  /// ide ha a StudList view-t hívom meg, nem ismeri fel
        {
            return View();
        }


        //public ActionResult StudentList()
        //{
        //    using (MyDataBaseEntitiess dc = new MyDataBaseEntitiess())
        //    {
        //        var v = dc.StudentInfoes.ToList();
        //        return View(v);
        //    }
        //}
    }
}