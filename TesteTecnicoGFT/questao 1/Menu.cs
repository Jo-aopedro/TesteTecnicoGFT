using System;

namespace TesteTecnicoGFT.questao1
{

	public class Menu : Operacoes
	{
        public void Menu2(string resultado)
        {
            Console.Clear();
            Console.WriteLine("Digite a opção desejada");
            Console.WriteLine(("|1| Imprimir o resultado;");
            Console.WriteLine(("|2| Voltar  o resultado;");
        }
		public void Menu()
		{
			int opcao;

			do
			{
                Console.WriteLine("Questão 1");
                Console.WriteLine("Digite o número correspondente a operação desejada:");
                Console.WriteLine("| 1 | Soma			|");
                Console.WriteLine("| 2 | Subtração		|");
                Console.WriteLine("| 3 | Divisão		|");
                Console.WriteLine("| 4 | Multiplicação	|");
                Console.WriteLine("| 5 | Sair			|");

				opcao = int.Parse(Console.ReadLine());
                string resultado;
                switch (opcao)
                {
                    case 1:
                        Console.Clear()
                        double a, b;
                        Console.WriteLine("Soma");
                        Console.WriteLine("Digite o primeiro número:");
                        a=double.Parse(Console.ReadLine())
                        Console.WriteLine( "Digite o segundo número:");
                        b=double.Parse(Console.ReadLine())
                        resultado = ToString( Operacoes.Soma(a, b));
                        break;
                    case 2
                        Console.Clear()
                        double a, b;
                        Console.WriteLine("Subtração");
                        Console.WriteLine("Digite o primeiro número:");
                        a = double.Parse(Console.ReadLine())
                        Console.WriteLine("Digite o segundo número:");
                        b = double.Parse(Console.ReadLine())
                        resultado = ToString(Operacoes.Subtracao(a, b));
                        break;
                    case 3
                        Console.Clear()
                        double a, b;
                        Console.WriteLine("Multiplicação");
                        Console.WriteLine("Digite o primeiro número:");
                        a = double.Parse(Console.ReadLine())
                        Console.WriteLine("Digite o segundo número:");
                        b = double.Parse(Console.ReadLine())
                        resultado = ToString(Operacoes.Multiplicacao(a, b));
                        break;
                    case 4
                        Console.Clear()
                        double a, b;
                        Console.WriteLine("Divisão");
                        Console.WriteLine("Digite o dividendo:");
                        a = double.Parse(Console.ReadLine())
                        Console.WriteLine("Digite o divisor:");
                        b = double.Parse(Console.ReadLine())
                        resultado = Operacoes.Divisao(a, b);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção Inválida, tente novamente");
                        Menu();

                        break;
                }


            } while (opcao != 5);
		}
	}
}

