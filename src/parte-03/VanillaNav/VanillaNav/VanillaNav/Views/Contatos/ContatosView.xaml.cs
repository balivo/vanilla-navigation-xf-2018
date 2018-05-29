using System.Collections.ObjectModel;
using VanillaNav.Services.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VanillaNav.Views.Contatos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContatosView : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public ContatosView()
        {
            InitializeComponent();

            Items = new ObservableCollection<string>
            {
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4",
                "Item 5"
            };

            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await NavigationService.Current.NavigateTo(new ContatoView(e.Item));

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
