using System.Collections.Generic;

namespace Omdb.Net.Models
{
    public class Movie
    {
        public string Title;
        public string Year;
        public string Rated { get; set; }
        public string RunTime { get; set; }
        public string Released;
        public string Genre;
        public string Director;
        public string Writer;
        public string Actors;
        public string Plot { get; set; }
        public string Language;
        public string Country;
        public string Awards;
        public string Poster;
        public string Metascore;
        public string imdbRating;
        public string imdbVotes;
        public string imdbID;
        public string Type;
        public string DVD { get; set; }
        public string BoxOffice { get; set; }
        public string Production { get; set; }
        public string Website { get; set; }
        public string Response;
        public Tomatoes Ratings;
    }
}
