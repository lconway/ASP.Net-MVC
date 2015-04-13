using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMovie.Models;
using PagedList;

namespace MvcMovie.Controllers
{
    public class MoviesController : Controller
    {
        private MovieDBContext db = new MovieDBContext();

        //
        // /SearchIndex/

        public ActionResult SearchIndex(string movieGenre, string searchString) {
            var GenreList = new List<string>();

            var GenreQry = from d in db.Movies
                           orderby d.Genre
                           select d.Genre;
            GenreList.AddRange(GenreQry.Distinct());
            ViewBag.movieGenre = new SelectList(GenreList);

            var movies = from m in db.Movies
                         select m;

            if (!String.IsNullOrEmpty(searchString))
                movies = movies.Where(s => s.Title.Contains(searchString));

            if (String.IsNullOrEmpty(movieGenre))
                return View(movies);
            else
                return View(movies.Where(x => x.Genre == movieGenre));
        }

        //
        // GET: /Movies/

        public ActionResult Index(int? page) {

            var movies = from m in db.Movies
                         select m;
            movies = movies.OrderBy(m => m.Title);

            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(movies.ToPagedList(pageNumber, pageSize));
        }

        //
        // GET: /Movies/Details/5

        public ActionResult Details(int id = 0)
        {
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        //
        // GET: /Movies/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Movies/Create

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movie);
        }

        //
        // GET: /Movies/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        //
        // POST: /Movies/Edit/5

        [HttpPost]
        public ActionResult Edit(Movie movie, HttpPostedFileBase image)
        {
            if (ModelState.IsValid)
            {
                if (image != null) {
                    movie.ImageMimeType = image.ContentType;
                    movie.ImageData = new byte[image.ContentLength];
                    image.InputStream.Read(movie.ImageData, 0, image.ContentLength);
                }

                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        //
        // /Movies/GetImage
        public FileContentResult GetImage(int id) {
            Movie movie = db.Movies.Find(id);
            if (movie != null)
                return File(movie.ImageData, movie.ImageMimeType);
            else
                return null;
        }

        //
        // GET: /Movies/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        //
        // POST: /Movies/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Movie movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}