using System;
using System.Collections.Generic;
using System.Text;

namespace Eleicoes2020.Models
{
    public class Candidato
    {
        public int numero { get; set; }
        public string nome { get; set; }
        public Partido partido { get; set; }
        public int qtdeVotos { get; set; }
    }
}
