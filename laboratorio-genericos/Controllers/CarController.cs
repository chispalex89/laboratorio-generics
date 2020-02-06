using laboratorio_genericos.Models;
using CustomGenerics.Structures;
using System;
//using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace laboratorio_genericos.Controllers
{
    public class CarController : Controller
    {
        //
        // GET: /Car/
        public ActionResult Index()
        {
           // var cars = new List<CarModel>
           // {
           ////     new CarModel { Brand = "Chevrolet", Model = "Camaro", Year = 2020, Color = "Yellow", CubicCms = 200 },
           //     //new CarModel { Brand = "Kia", Model = "Picanto", Year = 2012, Color = "Red", CubicCms = 50 }
           // };
            var cars = new Queue<CarModel>();
            cars.Enqueue(new CarModel { Brand = "Chevrolet", Model = "Camaro", Year = 2020, Color = "Yellow", CubicCms = 200 });
            cars.Enqueue(new CarModel { Brand = "Kia", Model = "Picanto", Year = 2012, Color = "Red", CubicCms = 50 });
            return View(cars);
        }

        //
        // GET: /Car/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Car/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Car/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Car/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Car/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Car/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Car/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
