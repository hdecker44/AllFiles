using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class StreamingRepository : StreamingContentRepository
    {
        // Get All Shows - Method
        public List<Show> GetAllShows()
        {
            // Make a new list of Shows
            List<Show> shows = new List<Show>();
            // Look at all streaming content and check if it's a Show
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Show)
                // Add each show to a list of Shows
                // if (content is Show *variable*) --- if statement is true // Pattern Matching
                {
                    // Pattern Matching continued:  shows.Add(*variable*);
                    // Cast 
                    shows.Add((Show)content);                   
                }
            }
            // Return our list of Shows
            return shows;
        }
        // Get All Movies - Method
        public List<Movie> GetAllMovies()
        {
            // Make a new list of Movies
            List<Movie> movies = new List<Movie>();
            // Look at all streaming content and check if it's a Movie
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Movie)
                // Add each movie to a list of Movies
                // if (content is Movie *variable*) --- if statement is true // Pattern Matching
                {
                    // Pattern Matching continued:  movies.Add(*variable*);
                    // Cast 
                    movies.Add((Movie)content);
                }
            }
            // Return our list of Movies
            return movies;
        }
        // Get Show by Title - Method
        // Get Movie by Title - Method

        // Update Existing Show - Method
        // Update Existing Movie - Method

        // Delete Show by Title - Method
        // Delete Movie by Title - Method
    }
}
