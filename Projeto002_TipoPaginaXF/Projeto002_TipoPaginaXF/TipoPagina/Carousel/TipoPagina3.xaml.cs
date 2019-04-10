using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto002_TipoPaginaXF.TipoPagina.Carousel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TipoPagina3 : ContentPage
	{
		public TipoPagina3 ()
		{
			InitializeComponent ();
		}
        private void MudarPagina(object sender, EventArgs args)
        {
            //App.Current.MainPage =new NavigationPage(new Navigation.Pagina1()) { BackgroundColor = Color.Transparent};//força a pagina a trocar do carousel page para pagina 1
            App.Current.MainPage = new Tabbed.Abas();
            //primeiro vai ser atribuida a navigation page para depois a pagina 1 para poder ser utilizado em outra classe
        }

    }
}