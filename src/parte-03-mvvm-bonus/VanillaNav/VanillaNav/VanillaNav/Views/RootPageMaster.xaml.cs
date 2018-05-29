using System;
using VanillaNav.Services.Navigation;
using VanillaNav.ViewModels;
using Xamarin.Forms;

namespace VanillaNav.Views
{
    public partial class RootPageMaster : ContentPage
    {
        public RootPageMaster()
        {
            InitializeComponent();

            BindingContext = new RootPageMasterViewModel();
        }

        async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                if (((ListView)sender).SelectedItem == null)
                    return;

                var destinationPage = (Page)Activator.CreateInstance(((RootPageMenuItemViewModel)((ListView)sender).SelectedItem).TargetType);

                await NavigationService.Current.NavigateTo(destinationPage, true);

                ((ListView)sender).SelectedItem = null;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Eita!", $"Algo de errado não deu certo: {ex.Message}", "Ok");
            }
        }
    }
}