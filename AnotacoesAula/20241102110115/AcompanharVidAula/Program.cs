using System.Globalization;

namespace Course
{
	class Program
	{
		static void Main(string[] args)
		{
			double a;
			int b;
			//valores apos ponto/virgula truncados na conversao explicita pra int
			a = 5.1;
			b = (int)a;
            Console.WriteLine(b);

        }
	}
}