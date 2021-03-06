using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGFT
{
    class Funcionario : Pessoa
    {
        public double Salario_inicial { get; private set; }
        public double Porcentagem { get; private set; }
        public double Salario_final { get; private set; }

        public Funcionario(double inicial, double porcentagem, double final, string nome, string rg) : base(nome, rg)
        {
            this.Salario_inicial = inicial;
            this.Porcentagem = porcentagem;
            this.Salario_final = final;
        }
    }
}
