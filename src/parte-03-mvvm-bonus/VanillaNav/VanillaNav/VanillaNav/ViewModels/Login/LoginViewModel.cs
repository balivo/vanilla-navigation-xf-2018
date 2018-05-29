using System.Threading.Tasks;
using VanillaNav.Services.Navigation;
using Xamarin.Forms;

namespace VanillaNav.ViewModels.Login
{
    sealed class LoginViewModel : ViewModelBase
    {
        public LoginViewModel()
        {

        }

        private Command _AutenticarCommand;
        public Command AutenticarCommand => _AutenticarCommand ??
            (_AutenticarCommand = new Command(() => AutenticarCommandExecute()));

        void AutenticarCommandExecute()
        {
            App.IsAuthenticated = true;

            NavigationService.Current.InitializeRoot();
        }


        private Command _RegistrarCommand;
        public Command RegistrarCommand => _RegistrarCommand ??
            (_RegistrarCommand = new Command(async () => await RegistrarCommandExecute()));

        Task RegistrarCommandExecute()
        {
            // Ir para página de registro...
            //return NavigationService.Current.NavigateTo(....);

            return Task.FromResult<object>(null);
        }
    }
}
