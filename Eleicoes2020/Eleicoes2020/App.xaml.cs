using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Eleicoes2020.Models;

namespace Eleicoes2020
{
    public partial class App : Application
    {
        public static List<Candidato> candidatos = new List<Candidato>();

        public App()
        {
            InitializeComponent();
            MainPage = new Eleicoes2020.Views.Menu();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
