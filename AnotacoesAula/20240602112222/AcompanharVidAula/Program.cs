/*
 Ex 2
 Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
*/

using System;
class Program
{
	static void Main()
	{
		int inteiro = int.Parse(Console.ReadLine());

		if (inteiro % 2 == 0)
		{
			Console.WriteLine("PAR");
		}
		else
		{
			Console.WriteLine("IMPAR");
		}
        
    }
}