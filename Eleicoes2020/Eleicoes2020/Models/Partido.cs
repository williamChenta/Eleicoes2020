using System;
using System.Collections.Generic;
using System.Text;

namespace Eleicoes2020.Models
{
    public class Partido
    {
        public string sigla { get; set; }
        public string nome { get; set; }

        public override string ToString()
        {
            return $"{sigla} - {nome}";
        }
    }
}
