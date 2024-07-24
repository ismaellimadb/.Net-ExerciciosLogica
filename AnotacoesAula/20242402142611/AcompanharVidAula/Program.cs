/*
  Exercício 05
	Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
 */

using System;
using System.Globalization;

namespace Course
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Entrada: ");
			string[] vet = Console.ReadLine().Split(' ');
			int a = int.Parse(vet[0]);
			int b = int.Parse(vet[1]);
			double c = double.Parse(vet[2], CultureInfo.InvariantCulture); ;

			string[] vet2 = Console.ReadLine().Split(' ');
			int d = int.Parse(vet2[0]);
			int e = int.Parse(vet2[1]);
			double f = double.Parse(vet2[2], CultureInfo.InvariantCulture); ;

			double resultado = (b * c) + (e * f);

			Console.WriteLine($"VALOR A PAGAR: R$ {resultado.ToString("F2",CultureInfo.InvariantCulture)}");
		}
	}
}