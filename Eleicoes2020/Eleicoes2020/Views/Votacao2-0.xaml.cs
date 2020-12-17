using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Eleicoes2020.Models;

namespace Eleicoes2020.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Votacao2_0 : ContentPage
    {
        string numero = "";
        public string foto = "https://i.pinimg.com/originals/ee/15/0f/ee150f0403192ea285823007a37f080d.jpg";
        public string[] fotoJog = { "https://s2.glbimg.com/yCiqHcgr7fleOoZ7v9VZZGpSrgw=/0x0:5568x3712/984x0/smart/filters:strip_icc()/i.s3.glbimg.com/v1/AUTH_bc8228b6673f488aa253bbcb03c80ec5/internal_photos/bs/2018/m/c/c9h6j4QsWq8cb3LZ0iOw/000-15e04p.jpg" };

        public Votacao2_0()
        {
            InitializeComponent();
            fotoCandidato.Source = foto;
        }

        private void registraNumero(object sender, EventArgs e)
        {
            Button clicado = (Button)sender;
            numero += clicado.CommandParameter.ToString();

            if (numero.Length >= 2)
            {
                buscaCandidato();
            }
        }

        private void buscaCandidato()
        {
            var c = from cand in App.candidatos
                          where cand.numero == int.Parse(numero)
                          select cand;

            Candidato candidato = c.FirstOrDefault();

            if (candidato != null)
            {
                foto = fotoJog[0];
            }
        }
    }
}