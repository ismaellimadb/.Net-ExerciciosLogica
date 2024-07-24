/*
  Exercício 04
	Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
decimais.
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
			int a = int.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());
			double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			double salary = (b * c);
			Console.WriteLine($"Saida:\nNUMBER = {a}\nSALARY = U$ {salary.ToString("F2", CultureInfo.InvariantCulture)}");
		}
	}
}