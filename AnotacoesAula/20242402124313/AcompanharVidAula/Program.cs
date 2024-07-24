/*
  Exercício 02
	Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
casas decimais 
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
			double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			double raio = Math.PI * Math.Pow(a, 2);
			Console.WriteLine($"Saida:\nA = {raio.ToString("F4", CultureInfo.InvariantCulture)}");
		}
	}
}