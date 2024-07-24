﻿/*
  Exercício 06
	Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.
 */
using System;
using System.Globalization;

class Program
{
	static void Main()
	{
		Console.WriteLine("Entrada: ");

		string[] inputs = Console.ReadLine().Split(' ');

		double A = double.Parse(inputs[0], CultureInfo.InvariantCulture);
		double B = double.Parse(inputs[1], CultureInfo.InvariantCulture);
		double C = double.Parse(inputs[2], CultureInfo.InvariantCulture);

		double areaTriangulo = (A * C) / 2.0;
		double areaCirculo = 3.14159 * C * C;
		double areaTrapezio = ((A + B) * C) / 2.0;
		double areaQuadrado = B * B;
		double areaRetangulo = A * B;

		Console.WriteLine($"Saida:");
		Console.WriteLine($"TRIANGULO: {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}");
		Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");
		Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
		Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
		Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
	}
}