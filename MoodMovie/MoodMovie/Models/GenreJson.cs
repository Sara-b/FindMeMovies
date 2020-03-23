using MoodMovie.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MoodMovie.Models
{
    public class GenreJson
    {
        [JsonProperty("genres")]
        public List<Genre> genres { get; set; }
    }
}