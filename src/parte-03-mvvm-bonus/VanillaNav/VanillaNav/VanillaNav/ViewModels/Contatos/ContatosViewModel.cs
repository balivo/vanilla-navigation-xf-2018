using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace VanillaNav.ViewModels.Contatos
{
    sealed class ContatosViewModel : ViewModelBase
    {
        public ObservableCollection<string> Itens { get; private set; }

        public ContatosViewModel()
        {
            Itens = new ObservableCollection<string>
            {
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4",
                "Item 5"
            };
        }
    }
}
