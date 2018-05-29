using System;
using VanillaNav.Services.Navigation;
using Xamarin.Forms;

namespace VanillaNav.Views
{
    public partial class RootPage : MasterDetailPage
    {
        public RootPage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (!(e.SelectedItem is RootPageMenuItem item))
                return;

            // Crio uma instância da página de destino...
            var destinationPage = (Page)Activator.CreateInstance(item.TargetType);

            await NavigationService.Current.NavigateTo(destinationPage, true);

            MasterPage.ListView.SelectedItem = null;
        }
    }
}