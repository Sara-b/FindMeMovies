using MoodMovie.Models;
using MoodMovie.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Text;

namespace MoodMovie.Controllers
{
    public class MoviesController : Controller
    {
        private string sort = "popularity.desc";
        private string urlMovies = "http://api.themoviedb.org/3/discover/movie?with_genres={0}&sort_by={1}&api_key={2}&page={3}";
        private List<Movie> moviesList = new List<Movie>();
        WebClient client = new WebClient() { Encoding = Encoding.UTF8 };

        //ACTIONS

        /// <summary>
        /// Get movies from 10 first pages by category sort by popularity
        /// </summary>
        /// <param name="id">id de la catégorie</param>
        /// <returns></returns>
        public ActionResult GetMoviesByGenre(int id)
        {
            //first call
            string urlGetMovies = string.Format(urlMovies, id, sort, HomeController.key, 1);
            dynamic json = client.DownloadString(urlGetMovies);
            var moviesJson = new JavaScriptSerializer().DeserializeObject(json);

            //call on several pages
            for (int i = 2; i < moviesJson["total_pages"] && i < 10; i++)
            {
                AddMovieToListByPage(id, i);
            }

            return View(new MoviesViewModel(moviesList));
        }

        /// <summary>
        /// Get the details of one movie
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        public ActionResult Details(int id)
        {
            string urlGetMovie = string.Format("http://api.themoviedb.org/3/movie/{0}?api_key={1}", id, HomeController.key);
            dynamic json = client.DownloadString(urlGetMovie);

            Movie movie = new JavaScriptSerializer().Deserialize<Movie>(json);
            
            return View(new DetailMovieViewModel(movie));
        }


        //METHODES
        public void AddMovieToListByPage(int id, int page)
        {
            string urlGetMovies = string.Format(urlMovies, id, sort, HomeController.key, page);
            dynamic json = client.DownloadString(urlGetMovies);
            var moviesJson = new JavaScriptSerializer().DeserializeObject(json);

            foreach (var movie in moviesJson["results"])
            {
                moviesList.Add(new Movie(movie["id"], movie["title"], movie["backdrop_path"], movie["popularity"], movie["vote_average"]));
            }
        }
    }
}