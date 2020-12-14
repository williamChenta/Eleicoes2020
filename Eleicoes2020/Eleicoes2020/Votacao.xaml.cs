using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eleicoes2020.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Eleicoes2020
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Votacao : ContentPage
    {
        public Votacao()
        {
            InitializeComponent();
            lstCandidatos.ItemsSource = App.candidatos;
        }

        private void Votar(object sender, EventArgs e)
        {
            Button clicado = (Button)sender;
            int numero = int.Parse(clicado.CommandParameter.ToString());

            var cand =  from c in App.candidatos
                        where c.numero == numero
                        select c;

            Candidato candidato = cand.FirstOrDefault();
            candidato.qtdeVotos++;

            DisplayAlert("Eleições 2020", $"Você votou no candidato {candidato.nome}. Obrigado!", "OK");
        }
    }
}