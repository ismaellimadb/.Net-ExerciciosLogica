/*
Ex6
Ler um número inteiro N e calcular todos os seus divisores.
*/

using System;
using System.Globalization;

namespace Course
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{
				if (n % i == 0)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}
