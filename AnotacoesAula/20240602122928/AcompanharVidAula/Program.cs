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
		int[] multiplosA = new int[A];
		int[] multiplosB = new int[B];
		bool multiplo = false;
		if (B > A)
		{
			for (int i = 0; i < B; i++)
			{
				multiplosB[i] = i;
			}

			foreach (int b in multiplosB)
			{
				if (A * b == B)
				{
					multiplo = true;
					break;
				}
			}
		}
		else
		{
			for (int i = 0; i < A; i++)
			{
				multiplosA[i] = i;
			}

			foreach (int a in multiplosA)
			{
				if (B * a == A)
				{
					multiplo = true;
					break;
				}
			}
		}
		

		if (multiplo == true)
		{
            Console.WriteLine("Sao Multiplos");
        }
		else
		{
			Console.WriteLine("Nao sao Multiplos");
		}
	}
}