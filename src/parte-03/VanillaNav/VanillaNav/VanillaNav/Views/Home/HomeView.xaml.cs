using System;
using VanillaNav.Views.Contatos;
using Xamarin.Forms;

namespace VanillaNav.Views.Home
{
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContatosView(), true);
        }
    }
}