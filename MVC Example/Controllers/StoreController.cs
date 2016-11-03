using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Example.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            ViewBag.Message = "This is my store index page!";

            return View();
        }


        // GET: Store/Browse?genre=Rock
        public ActionResult Browse(string genre)
        {
            ViewBag.Message = HttpUtility.HtmlEncode("Store.Browse, Genre= " + genre);

            return View();
        }


        // GET: Store/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Message = HttpUtility.HtmlEncode("Store.Details, ID= " + id);

            return View();
        }

    }
}