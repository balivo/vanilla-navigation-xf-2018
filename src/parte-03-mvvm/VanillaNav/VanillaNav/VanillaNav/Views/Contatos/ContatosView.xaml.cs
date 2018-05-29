using System.Collections.ObjectModel;
using VanillaNav.Services.Navigation;
using VanillaNav.ViewModels.Contatos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VanillaNav.Views.Contatos
{
    public partial class ContatosView : ContentPage
    {
        

        public ContatosView()
        {
            InitializeComponent();

            BindingContext = new ContatosViewModel();
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await NavigationService.Current.NavigateTo(new ContatoView(e.Item));

            ((ListView)sender).SelectedItem = null;
        }
    }
}
