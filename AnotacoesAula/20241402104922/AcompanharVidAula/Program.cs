/*
 Ex 6
Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”
*/

using System;
using System.Globalization;
class Program
{
	static void Main()
	{
		string[] valor = Console.ReadLine().Split(' ');
		double x = double.Parse(valor[0]);
		double y = double.Parse(valor[1]);

		if (x == 0 && y == 0)
		{
			Console.WriteLine("Origem");
		}
		else if (x == 0)
		{
			Console.WriteLine("Eixo Y");
		}
		else if (y == 0)
		{
			Console.WriteLine("Eixo X");
		}
		else if (x > 0 && y > 0)
		{
			Console.WriteLine("Q1"); 
		}
		else if (x < 0 && y > 0)
		{
			Console.WriteLine("Q2"); 
		}
		else if (x < 0 && y < 0)
		{
			Console.WriteLine("Q3"); 
		}
		else if (x > 0 && y < 0)
		{
			Console.WriteLine("Q4"); 
		}
	}
}