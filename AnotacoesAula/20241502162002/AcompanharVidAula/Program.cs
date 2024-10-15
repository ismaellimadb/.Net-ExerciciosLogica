using System;
using System.Globalization;

namespace Course
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Digite a senha: ");
			string x = Console.ReadLine();

			while (x != "2002")
			{
				Console.WriteLine("Senha Invalida");
				x = Console.ReadLine();
			}

            Console.WriteLine("Acesso Permitido");
        }

	}
}