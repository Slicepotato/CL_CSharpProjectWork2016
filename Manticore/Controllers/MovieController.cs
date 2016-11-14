using Manticore.Context;
using Manticore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Manticore.Controllers
{
    public class MovieController : Controller
    {
        private MovieContext db = new MovieContext();
        // GET: Product
        public ActionResult Index()
        {
            return View(db.Movies.ToList());
        }

        // GET: Product/Details/5
        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Movie movie = db.Movies.Find(id);
            if(movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }

        // GET: Product/Create
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            try
            {
                // TODO: Add insert logic here
                if(ModelState.IsValid)
                {
                    db.Movies.Add(movie);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(movie);
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Movie movie = db.Movies.Find(id);
            if(movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            try
            {
                // TODO: Add update logic here
                if(ModelState.IsValid)
                {
                    db.Entry(movie).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(movie);
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, Movie film)
        {
            try
            {
                Movie movie = new Movie();

                // TODO: Add delete logic here
                if(ModelState.IsValid)
                {
                    if(id == null)
                    {
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    }

                    movie = db.Movies.Find(id);
                    if(movie == null)
                    {
                        return HttpNotFound();
                    }

                    db.Movies.Remove(movie);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(movie);
            }
            catch
            {
                return View();
            }
        }
    }
}
