using Movies.Models;
using System;
using System.Linq;
using Xamarin.Forms;

namespace Movies.Views
{
    public partial class MoviesPage : ContentPage
    {
        public MoviesPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Retrieve all the notes from the database, and set them as the
            // data source for the CollectionView.
            collectionView.ItemsSource = await App.Database.GetMoviesAsync();
        }

        async void OnAddClicked(object sender, EventArgs e)
        {
            // Navigate to the NoteEntryPage.
            await Shell.Current.GoToAsync(nameof(MovieEntryPage));
        }

        async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                // Navigate to the NoteEntryPage, passing the ID as a query parameter.
                Movie movie = (Movie)e.CurrentSelection.FirstOrDefault();
                await Shell.Current.GoToAsync($"{nameof(MovieEntryPage)}?{nameof(MovieEntryPage.ItemId)}={movie.ID.ToString()}");
            }
        }
    }
}