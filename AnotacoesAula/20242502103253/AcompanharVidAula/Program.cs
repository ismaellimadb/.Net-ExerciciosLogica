using System;
class Program
{
	static void Main()
	{
        Console.WriteLine("Entre com um número inteiro:");
		int x = int.Parse(Console.ReadLine());
		
		if (x % 2 == 0) //resto da divisao de 2 = 0 verficando par
		{
			Console.WriteLine("Par!");
		}
		else
		{
            Console.WriteLine("Impar!");
        }
    }
}