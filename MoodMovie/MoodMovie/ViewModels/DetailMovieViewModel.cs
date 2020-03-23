using MoodMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodMovie.ViewModels
{
    public class DetailMovieViewModel
    {
        public Movie Movie { get; set; }
        public string imageBaseUrl = "http://image.tmdb.org/t/p/w500/";

        public DetailMovieViewModel(Movie movie)
        {
            Movie = movie; 
        }
    }
}
