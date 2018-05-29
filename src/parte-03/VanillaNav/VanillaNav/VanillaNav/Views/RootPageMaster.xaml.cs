using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using VanillaNav.Views.Contatos;
using VanillaNav.Views.Home;
using Xamarin.Forms;

namespace VanillaNav.Views
{
    public partial class RootPageMaster : ContentPage
    {
        public ListView ListView;

        public RootPageMaster()
        {
            InitializeComponent();

            BindingContext = new RootPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class RootPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<RootPageMenuItem> MenuItems { get; set; }
            
            public RootPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<RootPageMenuItem>(new[]
                {
                    new RootPageMenuItem { Id = 0, Title = "Home", TargetType = typeof(HomeView) },
                    new RootPageMenuItem { Id = 1, Title = "Contatos", TargetType = typeof(ContatosView) },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}