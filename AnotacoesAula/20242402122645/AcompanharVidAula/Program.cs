/*
  Exercício 01
	Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
	mensagem explicativa, conforme exemplo
Exemplo
Entrada:
10
Saida
20

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
            Console.WriteLine($"Saida: \nSOMA = {a + b}");
        }
	}
}