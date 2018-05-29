using System;
using System.Collections.Generic;
using System.Text;

namespace VanillaNav.ViewModels.Contatos
{
    sealed class ContatoViewModel : ViewModelBase
    {
        public ContatoViewModel(object args)
        {
            Title = args?.ToString() ?? "Novo Contato";
        }

        private string _Title;

        public string Title
        {
            get => _Title;
            set
            {
                _Title = value;
                OnPropertyChanged();
            }
        }
    }
}
