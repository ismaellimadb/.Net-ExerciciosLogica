using AcompanharVidAula;
using System;
using System.Globalization;

namespace Course
{
	class Program
	{
		static void Main(string[] args)
		{
			Pessoa pessoa1, pessoa2;

			pessoa1 = new Pessoa();
			pessoa2 = new Pessoa();

			pessoa1.Nome = Console.ReadLine();
			pessoa1.Idade = int.Parse(Console.ReadLine());

			pessoa2.Nome = Console.ReadLine();
			pessoa2.Idade = int.Parse(Console.ReadLine());
			
			if (pessoa1.Idade > pessoa2.Idade)
			{
				Console.WriteLine("{0} é mais velho que {1}", pessoa1.Nome, pessoa2.Nome);
			}
			else if (pessoa1.Idade == pessoa2.Idade)
			{
                Console.WriteLine("Ambos tem a mesma idade.");
            }
			else
			{
				Console.WriteLine("{1} é mais velho que {0}", pessoa1.Nome, pessoa2.Nome);
			}
		}
	}
}
