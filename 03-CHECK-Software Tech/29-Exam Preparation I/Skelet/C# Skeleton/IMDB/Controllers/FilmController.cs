using System.Linq;
using System.Net;
using System.Web.Mvc;
using IMDB.Models;

namespace IMDB.Controllers
{
    [ValidateInput(false)]
    public class FilmController : Controller
    {
        private IMDBDbContext db = new IMDBDbContext();


        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            var films = db.Films.ToList();
            return View(films);
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View(new Film());
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Film film)
        {
            if(this.ModelState.IsValid)
            {
                db.Films.Add(film);
                db.SaveChanges();
                return Redirect("/");
            }
            return View(film);
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int? id)
        {
            var films = db.Films.Find(id);
            if (films==null)
            {
                return HttpNotFound();
            }

            return View(films);
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int? id, Film filmModel)
        {
            var filmFromDB = db.Films.Find(id);
            if (filmFromDB==null)
            {
                return HttpNotFound();
            }

            if (this.ModelState.IsValid)
            {
                filmFromDB.Name = filmModel.Name;
                filmFromDB.Director = filmModel.Director;
                filmFromDB.Year = filmModel.Year;
                filmFromDB.Genre = filmModel.Genre;

                db.SaveChanges();
                return Redirect("/");
            }

            return View("edit", filmModel);
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int? id)
        {
            var films = db.Films.Find(id);
            if (films == null)
            {
                return HttpNotFound();
            }

            return View(films);
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int? id, Film filmModel)
        {
            var filmFromDB = db.Films.Find(id);
            if (filmFromDB == null)
            {
                return HttpNotFound();
            }

            db.Films.Remove(filmFromDB);
            db.SaveChanges();
            return Redirect("/");
        }
    }
}