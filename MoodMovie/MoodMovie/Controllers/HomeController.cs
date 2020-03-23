using MoodMovie.Models;
using MoodMovie.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MoodMovie.Controllers
{
    public class HomeController : Controller
    {
        public static string key = "9a16a9412a190da8bba6e3338b1527cc";

        public ActionResult Index()
        {
            string urlGetGenres = string.Format("http://api.themoviedb.org/3/genre/movie/list?api_key={0}", key);
            WebClient client = new WebClient();
            dynamic json = client.DownloadString(urlGetGenres);
            GenreJson moviesGenres = new JavaScriptSerializer().Deserialize<GenreJson>(json);

            return View(new GenresViewModel(moviesGenres));
        }
    }
}