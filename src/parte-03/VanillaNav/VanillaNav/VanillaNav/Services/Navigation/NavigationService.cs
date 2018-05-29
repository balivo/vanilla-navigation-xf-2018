using System;
using System.Threading.Tasks;
using VanillaNav.Views;
using Xamarin.Forms;

namespace VanillaNav.Services.Navigation
{
    sealed class NavigationService
    {
        private static Lazy<NavigationService> _Lazy = new Lazy<NavigationService>(() => new NavigationService());

        public static NavigationService Current { get => _Lazy.Value; }

        private NavigationService()
        {

        }

        // Acessar o "mecanismo"/stack de navegação do Xamarin.Forms
        private INavigation Navigation
        {
            get
            {
                return ((NavigationPage)((RootPage)App.Current.MainPage).Detail).Navigation;
            }
        }

        internal async Task NavigateTo(Page destinationPage, bool fromDrawer = false, bool animated = true)
        {
            try
            {
                if (fromDrawer)
                {
                    // Recupero a primeira página da pilha... 
                    var firstPage = Navigation.NavigationStack[0];

                    // Adiciono a página de destino, ANTES da primeira página inserida na pilha...
                    Navigation.InsertPageBefore(destinationPage, firstPage);

                    // Removo todas as páginas da pilha, mantendo somente a página Root, que passou a ser nossa
                    // página de destino, devido ao "InsertPageBefore"
                    await Navigation.PopToRootAsync(animated);

                    CloseDrawer();
                }
                else
                    await Navigation.PushAsync(destinationPage, animated);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void CloseDrawer() => ((RootPage)App.Current.MainPage).IsPresented = false;
    }
}
