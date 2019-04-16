using Omdb.Net.RequestBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            getMovies();

            do
            {
                Console.WriteLine("To stop at any time, enter 'c': ");
            }
            while (Console.ReadLine().Trim().ToUpper() != "C");


        }

        static async void getMovies()
        {
            var searchTerm = Console.ReadLine();
            var searchBuilder = OmdbSearchRequestBuilder.SearchTitle(searchTerm);
            var result = await searchBuilder.MakeRequest();

            if (result!=null)
            {
                foreach (var m in result.Search)
                {
                    Console.WriteLine(m.Title);
                    Console.WriteLine(m.Year);
                    Console.WriteLine(m.Type);
                    Console.WriteLine(m.imdbID);
                    Console.WriteLine(m.Poster);
                    Console.WriteLine("----------------------------------------------------");

                    
                } 
            }


        }

        static async void getDetails()
        {
            Console.WriteLine("Enter Imdb Id");
            var Id = Console.ReadLine();
            var moviedBuilder = OmdbIdRequestBuilder.Get(Id);
            var movie = await moviedBuilder.MakeRequest();
            Console.WriteLine(movie.Title);
            Console.WriteLine(movie.Year);
            Console.WriteLine(movie.Rated);
            Console.WriteLine(movie.Released);
            Console.WriteLine(movie.RunTime);
            Console.WriteLine(movie.Genre);
            Console.WriteLine(movie.Director);
            Console.WriteLine(movie.Writer);
            Console.WriteLine(movie.Actors);
            Console.WriteLine(movie.Plot);
            Console.WriteLine(movie.Language);
            Console.WriteLine(movie.Country);
            Console.WriteLine(movie.Awards);
            Console.WriteLine(movie.Poster);
            Console.WriteLine(movie.imdbRating);
            Console.WriteLine(movie.imdbVotes);
            Console.WriteLine(movie.imdbID);
            Console.WriteLine(movie.Type);
            Console.WriteLine(movie.BoxOffice);
        }
    }
}
