using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using VanillaNav.Views.Contatos;
using VanillaNav.Views.Home;

namespace VanillaNav.ViewModels
{
    class RootPageMasterViewModel : ViewModelBase
    {
        public ObservableCollection<RootPageMenuItemViewModel> Itens { get; set; }

        public RootPageMasterViewModel()
        {
            Itens = new ObservableCollection<RootPageMenuItemViewModel>(new[]
            {
                new RootPageMenuItemViewModel { Id = 0, Title = "Home", TargetType = typeof(HomeView) },
                new RootPageMenuItemViewModel { Id = 1, Title = "Contatos", TargetType = typeof(ContatosView) }
            });
        }
    }
}
