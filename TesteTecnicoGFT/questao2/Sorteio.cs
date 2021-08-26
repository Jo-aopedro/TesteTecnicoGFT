using System;

public class Sorteio
{
	Random random = new Random();
	List<int> sorteados = new List<int>;
	while (sorteados.Count!=4){
		int valor = random.Next(0, 20);
		if(!sorteados.Contains(valor)){
			sorteados.Add(valor);
		}
	}
	Console.WriteLine("Digite seus 4 números separados por espaço: ");
	int[] apostas = Console.ReadLine().Split(' ').Select(Int32.Parse);
	int acertos = 0;
	for (int i = 0; i < 4; i++)
	{
		if (sorteados.Contains(apostas[i]))
		{
			acertos ++
		}
	}
	if(acertos == 4)
	{
		Console.WriteLine("Parabéns! Você acertou os números!");
	}
	else
	{
		Console.WriteLine($"Que pena... Você só acertou {acertos} dos números");
	}
}


