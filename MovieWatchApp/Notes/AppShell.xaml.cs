using Movies.Views;
using Xamarin.Forms;

namespace Movies
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MovieEntryPage), typeof(MovieEntryPage));
        }
    }
}