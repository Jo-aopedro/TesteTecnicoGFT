using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGFT
{
    class Pares
    {
        public static void Imprime(int inicial,int final)
        {
            do
            {
                Console.Write(inicial + " ");
                inicial += 2;
            } while (inicial < final);
        }
        public static void Run()
        {
            Console.Clear();
            Console.Write("Digite o número inicial e o final separados por espaço: ");
            string[] imput = Console.ReadLine().Split(" ");
            try
            {
                int.TryParse(imput[0], out int inicial);
                int.TryParse(imput[1], out int final);
                if(inicial>0 && inicial < final)
                {
                    Console.WriteLine();
                    Console.Write("Os pares entre eles são: ");
                    if (inicial % 2 == 0) {

                        Imprime(inicial, final);
                    }
                    else {
                        Imprime(inicial + 1, final);
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Valores digitados inválidos");
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Entrada Inválida, tente novamente.");
            }
            

            

        }
    }
}
