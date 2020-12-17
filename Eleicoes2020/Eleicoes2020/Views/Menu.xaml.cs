using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Eleicoes2020.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
            Detail = new NavigationPage(new MenuDetail());
        }

		private void Cadastro(object sender, System.EventArgs e)
		{
			Detail.Navigation.PushAsync(new CadastroCandidato());
			IsPresented = false;
		}
		private void Votacao(object sender, System.EventArgs e)
		{
			Detail.Navigation.PushAsync(new Votacao2_0());
			IsPresented = false;
		}
		private void Resultado(object sender, System.EventArgs e)
		{
			Detail.Navigation.PushAsync(new Resultado());
			IsPresented = false;
		}
	}
}