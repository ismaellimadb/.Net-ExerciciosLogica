/*
 Ex 4
Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
seguir, calcule e mostre o valor da conta a pagar.
*/

using System;
using System.Globalization;
class Program
{
	static void Main()
	{
		Console.WriteLine("Cardapio\n1 Cachorro quente R$4.00\n2 X-Salada R$4.50\n3 X-Bacon R$5.00\n4 Torrada simples R$2.00\n5 Refrigerante 1.50");
		string[] valor = Console.ReadLine().Split(' ');
		int cod = int.Parse(valor[0]);
		double qtd = double.Parse(valor[1]);
		double total;

       switch(cod)
		{
			case 1:
				total = qtd * 4.00;
				Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
				break;
			case 2:
				total = qtd * 4.50;
				Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
				break;

			case 3:
				total = qtd * 5.00;
				Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
				break;

			case 4:
				total = qtd * 2.00;
				Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
				break;

			case 5:
				total = qtd * 1.50;
				Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
				break;
			default:
				Console.WriteLine($"Digite uma opção valida.");
				break;
		}
    }
	
}