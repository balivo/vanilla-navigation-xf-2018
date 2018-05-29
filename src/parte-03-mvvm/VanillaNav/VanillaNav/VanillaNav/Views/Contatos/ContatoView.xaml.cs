using VanillaNav.ViewModels.Contatos;
using Xamarin.Forms;

namespace VanillaNav.Views.Contatos
{
    public partial class ContatoView : ContentPage
    {
        public ContatoView(object args)
        {
            InitializeComponent();

            BindingContext = new ContatoViewModel(args);
        }
    }
}