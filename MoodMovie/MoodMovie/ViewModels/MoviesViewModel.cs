using MoodMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodMovie.ViewModels
{
    public class MoviesViewModel
    {
        public List<Movie> Movies { get;}
        public string imageBaseUrl = "http://image.tmdb.org/t/p/w500/";

        public MoviesViewModel(List<Movie> movies)
        {
            Movies = new List<Movie>(movies);
        }
    }
}
