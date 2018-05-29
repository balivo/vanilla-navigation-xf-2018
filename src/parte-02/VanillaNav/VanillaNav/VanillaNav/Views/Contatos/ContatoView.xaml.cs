using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VanillaNav.Views.Contatos
{
    public partial class ContatoView : ContentPage
    {
        public ContatoView(object args)
        {
            InitializeComponent();

            if (args != null)
                Title = args as string;
        }
    }
}