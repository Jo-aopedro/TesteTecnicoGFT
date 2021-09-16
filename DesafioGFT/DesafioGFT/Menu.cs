using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGFT
{
    class Menu
    {
        static int opcao;

        public static void Run()
        {
            Console.Clear();
            Console.Write("Digite a opção correspondente à operação que deseja realizar: ");
            Console.WriteLine();
            Console.WriteLine("|1| Soma         |");
            Console.WriteLine("|2| Subtração    |");
            Console.WriteLine("|3| Multiplicação|");
            Console.WriteLine("|4| Divisão      |");
            Console.WriteLine("|5| Sair         |");
            int.TryParse(Console.ReadLine(), out opcao);
            Console.Clear();
            Console.Write("Digite o primeiro número da operação: ");
            int.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine();
            Console.Write("Digite o segundo número da operação: ");
            int.TryParse(Console.ReadLine(), out int b);

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("O resultado da operação é {0}", Operacoes.Soma(a, b));
                    break;
                case 2:
                    Console.WriteLine("O resultado da operação é {0}", Operacoes.Subtracao(a, b));
                    break;
                case 3:
                    Console.WriteLine("O resultado da operação é {0}", Operacoes.Multiplicacao(a, b));
                    break;
                case 4:
                    if (b != 0)
                    {
                        Console.WriteLine("O resultado da operação é {0}", Operacoes.Divisao(a, b));
                    }
                    else
                    {
                        Console.WriteLine("Não é possível realizar divisão por 0, tente novamente.");
                    }
                    break;
                case 5:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("A opção digitada não corresponde a uma operação.");
                    break;
            }

            if (opcao != 5)
            {
                Console.WriteLine("Deseja retornar ao menú principal?");
                Console.WriteLine("|1| SIM");
                Console.WriteLine("|2| NÃO");

                int.TryParse(Console.ReadLine(), out int continua);

                if (continua == 1)
                    Run();
            }
        }
    }
}
