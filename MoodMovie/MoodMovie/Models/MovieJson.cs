using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodMovie.Models
{
    public class MovieJson
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("results")]
        public List<Movie> Movies { get; set; }

        [JsonProperty("total_results")]
        public int TotalResult { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }
}
