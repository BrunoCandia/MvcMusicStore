using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;
using System.Data;
namespace MvcMusicStore.Controllers
{
   
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        MusicStoreEntities storeDB = new MusicStoreEntities();

        public ActionResult Index()
        {
            //var genres = new List<Genre>
            //{
            //    new Genre { Name ="Disco"},
            //    new Genre { Name = "Jazz"},
            //    new Genre {Name = "Rock"}
            //};

            var genres = storeDB.Genres.ToList();
            return View(genres);
        }

        // GET: /Store/Browse?genre=Disco
        public ActionResult Browse(string genre)
        {
            //var genreModel = new Genre { Name = genre };
            //string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            //return message;

            var genreModel = storeDB.Genres.Include("Albums").Single(g => g.Name == genre);
            
            return View(genreModel);
        }

        // GET: /Store/Details/5
        public ActionResult Details(int id)
        {

            //string message = "Store.Details, ID= " + id;
            //var album = new Album { Title = "Album " + id };

            var album = storeDB.Albums.Find(id);


            return View(album);
        }
        //
        // GET: /Store/GenreMenu
        [ChildActionOnly]
        public  ActionResult GenreMenu()
        {
            var genres = storeDB.Genres.ToList();
            return PartialView(genres);
        }

    }
}
