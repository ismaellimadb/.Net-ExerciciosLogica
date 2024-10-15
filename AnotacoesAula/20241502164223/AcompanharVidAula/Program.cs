using System;
using System.Globalization;

namespace Course
{
	class Program
	{
		static void Main(string[] args)
		{
			int combustivel = int.Parse(Console.ReadLine());
			int alcool = 0;
			int gasolina = 0;
			int diesel = 0;
			while (combustivel != 4)
			{
				if (combustivel == 1)
				{
					alcool++;
				}
				else if (combustivel == 2)
				{
					gasolina++;
				}
				else if (combustivel == 3)
				{
					diesel++;
				}
				combustivel = int.Parse(Console.ReadLine());
			}
            Console.WriteLine($"MUITO OBRIGADO\nAlcool: {alcool}\nGasolina: {gasolina}\nDiesel: {diesel}");
        }
	}
}