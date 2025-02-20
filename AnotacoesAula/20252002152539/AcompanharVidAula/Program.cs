using AcompanharVidAula;
using System;
using System.Globalization;

namespace Course
{
	class Program
	{
		static void Main(string[] args)
		{
			string nome;
			double salarioBruto, salarioLiquido, porcentagem, imposto, aumento;

			Console.Write("Nome: ");
			nome = Console.ReadLine();

			Console.Write("Salário bruto: ");
			salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.Write("Imposto: ");
			imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			salarioLiquido = SalarioLiquido(salarioBruto, imposto);

			Console.Write($"\nFuncionario: {nome}, $ {salarioLiquido}");

			Console.WriteLine("\nDigite a porcentagem para aumentar o salário: ");
			porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			aumento = AumentarSalario(porcentagem, salarioBruto);

			Console.Write($"\nDados atualizados: {nome}, $ {salarioLiquido + aumento}");
		}

		public static double SalarioLiquido(double salarioBruto, double imposto)
		{
			return salarioBruto - imposto;
		}

		public static double AumentarSalario(double porcentagem, double salarioBruto)
		{
			//return salarioBruto * double.Parse($"0.{porcentagem}", CultureInfo.InvariantCulture);
			return salarioBruto * (porcentagem / 100.0);
		}
	}
}