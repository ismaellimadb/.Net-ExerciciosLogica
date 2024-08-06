/*
 Ex 1
 Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não
 */

using System;
class Program
{
	static void Main()
	{
		int inteiro = int.Parse(Console.ReadLine());

		if (inteiro > 0)
		{
			Console.WriteLine("NAO NEGATIVO");
		}
		else
		{
			Console.WriteLine("NEGATIVO");
		}
        
    }
}