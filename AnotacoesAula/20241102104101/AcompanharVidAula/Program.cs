using System.Globalization;

namespace Course
{
	class Program
	{
		static void Main(string[] args)
		{
			//conversao implicita pq float cabe no double
			float x = 4.5f;
			double y = x;

            Console.WriteLine(y);

			//conversao explicita pq float não cabe no double
			double a = 5.1f;
			float b = (float)a;

			Console.WriteLine(a);
		}
	}
}