using System.Collections.Generic;

namespace Omdb.Net.Models
{
    public class MovieSearch
    {
        public IList<MovieDetails> Search;
    }

    public class MovieDetails
    {
        public string Title;
        public string Year;
        public string imdbID;
        public string Type;
        public string Poster;
    }
}
