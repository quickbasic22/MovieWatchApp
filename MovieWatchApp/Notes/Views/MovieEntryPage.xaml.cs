using Movies.Models;
using System;
using Xamarin.Forms;

namespace Movies.Views
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public partial class MovieEntryPage : ContentPage
    {
        public string ItemId
        {
            set
            {
                LoadMovie(value);
            }
        }

        public MovieEntryPage()
        {
            InitializeComponent();

            // Set the BindingContext of the page to a new Note.
            BindingContext = new Movie();
        }

        async void LoadMovie(string itemId)
        {
            try
            {
                int id = Convert.ToInt32(itemId);
                // Retrieve the note and set it as the BindingContext of the page.
                Movie note = await App.Database.GetMovieAsync(id);
                BindingContext = note;
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to load note.");
            }
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var movie = (Movie)BindingContext;
            movie.Released = DateTime.UtcNow;
            if (!string.IsNullOrWhiteSpace(movie.Title))
            {
                await App.Database.SaveMovieAsync(movie);
            }

            // Navigate backwards
            await Shell.Current.GoToAsync("..");
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var movie = (Movie)BindingContext;
            await App.Database.DeleteNoteAsync(movie);

            // Navigate backwards
            await Shell.Current.GoToAsync("..");
        }
    }
}