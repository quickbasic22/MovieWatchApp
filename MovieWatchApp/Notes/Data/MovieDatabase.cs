using Movies.Models;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Movies.Data
{
    public class MovieDatabase
    {
        readonly SQLiteAsyncConnection database;

        public MovieDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Movie>().Wait();
        }

        public Task<List<Movie>> GetMoviesAsync()
        {
            //Get all notes.
            return database.Table<Movie>().ToListAsync();
        }

        public Task<List<MovieDetails>> GetMovieDetailsAsync()
        {
            //Get all notes.
            return database.Table<MovieDetails>().ToListAsync();
        }

        public Task<Movie> GetMovieAsync(int id)
        {
            // Get a specific note.
            return database.Table<Movie>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveMovieAsync(Movie movie)
        {
            if (movie.ID != 0)
            {
                // Update an existing note.
                return database.UpdateAsync(movie);
            }
            else
            {
                // Save a new note.
                return database.InsertAsync(movie);
            }
        }

        public Task<int> DeleteNoteAsync(Movie movie)
        {
            // Delete a note.
            return database.DeleteAsync(movie);
        }
    }
}
