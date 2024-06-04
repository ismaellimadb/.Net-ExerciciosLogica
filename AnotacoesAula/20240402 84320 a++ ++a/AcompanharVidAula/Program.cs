using System.Globalization;

namespace Course
{
	class Program
	{
		static void Main(string[] args)
		{
			//operadores aritimeticos/atribuição
			int a = 10;
			int b = a++; //primeiro joga valor aqui depois incrementa
			Console.WriteLine(a);
			Console.WriteLine(b);

			//operadores aritimeticos/atribuição
			int c = 10;
			int d = ++c; //primeiro incrementa
			Console.WriteLine(c);
			Console.WriteLine(d);
		}
	}
}