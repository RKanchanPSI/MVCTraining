using MVC_Training1.Models;
using MVC_Training1.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace MVC_Training1.Controllers
{
    public class FlowerController : Controller
    {
        private ApplicationDbContext _context;
        public FlowerController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var list = _context.Flowers.ToList();
            FlowerViewModel model = new FlowerViewModel
            {
                Flowers = list,
            };

            ViewBag.Flowers = list;
            return View(model);
        }
        public ActionResult Details(FlowerViewModel model)
        {
            var flower = _context.Flowers.FirstOrDefault(m => m.Name == model.SelectedFlower);
            ViewBag.Flower = flower;
            return View(model);
        }
    }
}   
