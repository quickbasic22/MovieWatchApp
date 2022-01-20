using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Movies.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            FsPath1.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            FsPath2.Text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            FsPath3.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            // Launch the specified URL in the system browser.
            await Launcher.OpenAsync("https://aka.ms/xamarin-quickstart");
        }
    }
}