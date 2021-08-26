using System;

namespace TesteTecnicoGFT.questao1
{
    public class Operacoes
    {
	    public static double Soma (double a, double b)
        {
            return a + b;
        }

        public static double Subtracao(double a, double b)
        {
            return a - b;
        }

        public static double Multiplicacao(double a, double b)
        {
            return a * b;
        }

        public static string Divisao(double a, double b)
        {
            b!=0?($"{a/b}"):($"Não é possível realizar divisão por 0. Tente novamente.")
        }
    }
}

