using System.Globalization;

namespace Course
{
	class Program
	{
		static void Main(string[] args)
		{
			char genero = 'F';
			int idade = 32;
			double saldo = 10.35784;
			string nome = "Maria";

            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde");
            Console.WriteLine("Boa noite");
			Console.WriteLine("------------------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
			//F2 duas casas decimas F3 3 casas e assim por diante
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
			//trocar virgula por ponto
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
        }
	}
}