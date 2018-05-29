using VanillaNav.Views;
using VanillaNav.Views.Login;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace VanillaNav
{
    public partial class App : Application
    {
        public static bool IsAuthenticated { get; set; } = false;

        public App()
        {
            InitializeComponent();

            if (IsAuthenticated)
                MainPage = new RootPage();
            else
                MainPage = new NavigationPage(new LoginView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
