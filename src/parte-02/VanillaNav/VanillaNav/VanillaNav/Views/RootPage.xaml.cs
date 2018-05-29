using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VanillaNav.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RootPage : MasterDetailPage
    {
        public RootPage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as RootPageMenuItem;

            if (item == null)
                return;

            // Crio uma instância da página de destino...
            var destinationPage = (Page)Activator.CreateInstance(item.TargetType);

            // Recupero a primeira página da pilha... 
            var firstPage = ((NavigationPage)Detail).Navigation.NavigationStack[0];

            // Adiciono a página de destino, ANTES da primeira página inserida na pilha...
            ((NavigationPage)Detail).Navigation.InsertPageBefore(destinationPage, firstPage);

            // Removo todas as páginas da pilha, mantendo somente a página Root, que passou a ser nossa
            // página de destino, devido ao "InsertPageBefore"
            ((NavigationPage)Detail).Navigation.PopToRootAsync(true);

            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}