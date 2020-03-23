using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodMovie.Models
{
    public class Movie
    {
        [JsonProperty("poster_path")]
        public string Poster_path { get; set; }

        [JsonProperty("adult")]
        public bool Adult { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("release_date")]
        public string Release_date { get; set; }

        [JsonProperty("genres")]
        public Genre[] Genres { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("original_title")]
        public string Original_title { get; set; }

        [JsonProperty("original_language")]
        public string Original_language { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("backdrop_path")]
        public string Backdrop_path { get; set; }

        [JsonProperty("popularity")]
        public decimal Popularity { get; set; }

        [JsonProperty("vote_count")]
        public int Vote_count { get; set; }

        [JsonProperty("video")]
        public bool Video { get; set; }

        [JsonProperty("vote_average")]
        public decimal Vote_average { get; set; }

        [JsonProperty("tagline")]
        public string Tagline { get; set; }

        [JsonProperty("imdb_id")]
        public string Imdb_id { get; set; }

        public Movie() { }

        public Movie(int id, string title, string imageUrl, decimal popularity, decimal voteAverage)
        {
            Id = id;
            Title = title;
            Backdrop_path = imageUrl;
            Popularity = popularity;
            Vote_average = voteAverage;
        }
    }
}
