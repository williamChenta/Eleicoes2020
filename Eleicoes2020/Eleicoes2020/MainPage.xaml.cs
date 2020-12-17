using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Eleicoes2020
{
    public partial class MainPage : ContentPage
    {
        public bool IsPresented { get; private set; }

        public MainPage()
        {
            InitializeComponent();
        }

        private void cadastrar(object sender, EventArgs e)
        {
            //DisplayAlert("Eleições 2020", "Você clicou no botão", "OK");
            Navigation.PushAsync(new CadastroCandidato());
            IsPresented = false;
        }

        private void Votar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Votacao());
            IsPresented = false;
        }

        private void Resultado(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Resultado());
            IsPresented = false;
        }
    }
}
