using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto002_TipoPaginaXF.TipoPagina.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pagina1 : ContentPage
	{
		public Pagina1 ()
		{
			InitializeComponent ();
		}
        private void MudarPagina2(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Pagina2()); //esse metodo consegue chamar a pagina 2 sem perder o historico de pagina
            //Salva as paginas acessadas para conseguir voltar na seta superior
            
        }
        private void ChamarModal(object sender, EventArgs args)
        {
            //modal e uma pagina q vai ser chamada sem interromper o fluxo do navigation page
            Navigation.PushModalAsync(new modal());
        }
        private void ChamarMaster(object sender, EventArgs args)
        {
            App.Current.MainPage = new Master.Master();
        }
    }
}