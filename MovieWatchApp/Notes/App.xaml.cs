using Movies.Data;
using System;
using System.IO;
using Xamarin.Forms;
using Movies.Views;

namespace Movies
{
    public partial class App : Application
    {
        static MovieDatabase database;

        public static MovieDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new MovieDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Movies.db3"));

                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            base.OnStart();
        }

        protected override void OnSleep()
        {
            base.OnSleep();
        }

        protected override void OnResume()
        {
            base.OnResume();
        }
    }
}