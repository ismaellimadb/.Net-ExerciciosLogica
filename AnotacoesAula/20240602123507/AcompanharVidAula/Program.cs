/*
 Ex 3
Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
ordem crescente ou decrescente.
*/

using System;
class Program
{
	static void Main()
	{
		string[] valor = Console.ReadLine().Split(' ');
		int A = int.Parse(valor[0]);
		int B = int.Parse(valor[1]);

		if (A % B == 0 || B % A == 0)
		{
			Console.WriteLine("Sao Multiplos");
		}
		else
		{
			Console.WriteLine("Nao sao Multiplos");
		}
	}
}