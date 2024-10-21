/*
Ex1
Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
X, se for o caso.
*/

using System;
using System.Globalization;

namespace Course
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.Write("Digite o valor: ");
			int x = int.Parse(Console.ReadLine());

			for (int i = 1;  i <= x; i++)
			{
				if (i % 2 != 0)
				{
					Console.WriteLine("Valor Impar #{0}: ", i);
				}
			}
        }
	}
}