using System;
using System.Globalization;

namespace Course
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Entre com seu nome completo:");
			string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
			int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
			double produto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha)");
			string[] s = Console.ReadLine().Split(' ');

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(produto.ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine(s[0]);
			Console.WriteLine(s[1]);
			Console.WriteLine(s[2],CultureInfo.InvariantCulture);
        }
	}
}