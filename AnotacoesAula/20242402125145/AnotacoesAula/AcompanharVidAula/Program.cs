/*
  Exercício 03
	Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
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
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());
			int d = int.Parse(Console.ReadLine());
			int soma = (a * b) - (c * d);
			Console.WriteLine($"Saida:\nDIFERENCA = {soma}");
		}
	}
}