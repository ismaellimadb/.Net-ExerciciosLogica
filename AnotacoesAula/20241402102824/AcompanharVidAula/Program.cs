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
		double entrada = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

		if(entrada >= 0 && entrada <= 25)
		{
			Console.WriteLine("Intervalo: 0,25");
		}
		else if (entrada >= 25 && entrada <= 50)
		{
			Console.WriteLine("Intervalo: 25,50");
		}
		else if (entrada >= 50 && entrada <= 75)
		{
			Console.WriteLine("Intervalo: 50,75");
		}
		else if (entrada >= 75 && entrada <= 100)
		{
			Console.WriteLine("Intervalo: 75,100");
		}
		else
		{
			Console.WriteLine("Fora de intervalo");
		}
	}
}