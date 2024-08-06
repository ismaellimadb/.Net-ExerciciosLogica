/*
 Ex 4
Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
*/

using System;
class Program
{
	static void Main()
	{
		string[] valor = Console.ReadLine().Split(' ');
		int A = int.Parse(valor[0]);
		int B = int.Parse(valor[1]);

		TimeSpan horaInicial = new TimeSpan(A, 0, 0);
		TimeSpan horaFinal = new TimeSpan(B, 0, 0);
		TimeSpan duracao;

		if (A == 0 && B == 0 || A == 0 && B == 24)
		{
			Console.WriteLine($"O JOGO DUROU 24 HORA(S");
		}
		else
		{
			if (horaFinal > horaInicial)
			{
				duracao = horaFinal - horaInicial;
			}
			else
			{
				duracao = (new TimeSpan(24, 0, 0) - horaInicial) + horaFinal;
			}

			Console.WriteLine($"O JOGO DUROU {duracao.ToString("hh")} HORA(S");
		}
	}
}