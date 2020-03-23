using MoodMovie.Controllers;
using MoodMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodMovie.ViewModels
{
    public class GenresViewModel
    {
        public List<Genre> MoviesGenres { get; set; }

        public GenresViewModel(GenreJson genreJson)
        {
            MoviesGenres = new List<Genre>(genreJson.genres);
        }
    }
}
