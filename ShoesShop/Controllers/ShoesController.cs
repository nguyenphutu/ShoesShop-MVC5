using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ShoesShop.DAL;
using ShoesShop.Models;

namespace ShoesShop.Controllers
{
    public class ShoesController : Controller
    {
        private ShoeDbContext db = new ShoeDbContext();

        // GET: Shoes
        public ActionResult Index()
        {
            return View(db.Shoes.ToList());
        }

        // GET: Shoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shoes shoes = db.Shoes.Find(id);
            if (shoes == null)
            {
                return HttpNotFound();
            }
            ViewBag.featuredProducts = db.Shoes.ToList().Skip(4).Take(4);
            return View(shoes);
        }        
    }
}
