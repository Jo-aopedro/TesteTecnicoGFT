using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGFT
{
    class Sorteio
    {
        static Random random = new Random();
        static int sorteado;

        public static void Aposta()
        {
            List<int> sorteados = new List<int> { };
            while (sorteados.Count != 4)
            {
                sorteado = random.Next(0, 20);
                if (!sorteados.Contains(sorteado))
                {
                    sorteados.Add(sorteado);
                }
            }
            int[] apostas = new int[4];
            int acertos = 0;
            Console.WriteLine("Bem vindo ao sorteio!");
            Console.WriteLine("Digite separadamente 4 numeros de aposta não repetidos.");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Digite um número: ");
                int.TryParse(Console.ReadLine(), out apostas[i]);
                Console.Clear();
            }

            Console.Write("Os números corretos são: ");
            for (int i = 0; i < apostas.Length; i++)
            {
                Console.Write(sorteados[i] + " ");
                if (sorteados.Contains(apostas[i]))
                {
                    acertos++;
                }
            }
            Console.WriteLine();
            if (acertos == 4)
            {
                Console.WriteLine("Parabéns! Você acertou os 4 números.");
            }
            else
            {
                Console.WriteLine("Que pena, você só acertou {0} números", acertos);
            }
        }
    }
}
