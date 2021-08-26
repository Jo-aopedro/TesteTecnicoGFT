using System;

public class Intervalo
{
	public void iniciar()
	{
        string resultado = "";
        bool continua = true;
        int inicio, final;
        while (continua)
        {
            Console.Clear();
            Console.WriteLine("Digite o início do intervalo (sendo maior que 0): ");
            inicio = int.Parse(Console.ReadLine());
            if (inicio > 0)
            {
                continua = false;
            }
            else
            {
                Console.WriteLine("Número inválido, tente novamente.");
            }
        }

        while (!continua)
        {
            Console.Clear();
            Console.WriteLine("Digite o final do intervalo (sendo maior que o início): ");
            final = int.Parse(Console.ReadLine());
            if (final > inicio)
            {
                continua = true
            }
            else
            {
                Console.WriteLine("O final não é maior que o início, tente novamente");
            }
        }
        
        for (int i = inicio; i <= final; i++)
        {
            if (i % 2 == 0)
            {
                resultado += $"{i} "
            }
        }

        Console.WriteLine(resultado);

	}
}
