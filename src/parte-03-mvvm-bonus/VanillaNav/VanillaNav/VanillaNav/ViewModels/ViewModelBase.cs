using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VanillaNav.ViewModels
{
    abstract class ViewModelBase : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        protected internal void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        #endregion
    }
}
