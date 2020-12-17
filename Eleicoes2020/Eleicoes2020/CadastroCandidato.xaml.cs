using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Eleicoes2020.Models;

namespace Eleicoes2020
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroCandidato : ContentPage
    {
        public static List<Candidato> candidatos;
        public List<Partido> partidos;

        public CadastroCandidato()
        {
            carregaPartidos();
            InitializeComponent();
            cmbPartidos.ItemsSource = partidos;
        }

        private void carregaPartidos()
        {
            partidos = new List<Partido>()
            {
                new Partido()
                {
                    nome = "Partido dos pilantras",
                    sigla = "PP"
                }, new Partido()
                {
                    nome = "Partido dos laranjas",
                    sigla = "PL"
                }, new Partido()
                {
                    nome = "Partido da nação corinthiana",
                    sigla = "PNC"
                }
            };
        }

        private void Salvar(object sender, EventArgs e)
        {
            Candidato cand = new Candidato()
            {
                numero = int.Parse(txtNumero.Text),
                nome = txtNome.Text,
                partido = (Partido)cmbPartidos.SelectedItem,
                foto = txtFoto.Text,
                qtdeVotos = 0
            };

            App.candidatos.Add(cand);
            DisplayAlert("Eleições 2020", "Candidato cadastrado com sucesso!", "OK");
        }

        private void Voltar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}