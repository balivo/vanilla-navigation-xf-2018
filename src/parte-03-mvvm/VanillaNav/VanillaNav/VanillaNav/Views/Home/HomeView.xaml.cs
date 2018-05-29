using VanillaNav.ViewModels.Home;
using Xamarin.Forms;

namespace VanillaNav.Views.Home
{
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();

            BindingContext = new HomeViewModel();
        }
    }
}