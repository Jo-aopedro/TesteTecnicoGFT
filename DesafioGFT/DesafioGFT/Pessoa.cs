using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGFT
{
    class Pessoa
    {
        public string Nome { get; private set; }
        public string Rg { get; private set; }

        public Pessoa(string nome, string rg)
        {
            this.Nome = nome;
            this.Rg = rg;
        }
    }
}
