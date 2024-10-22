using AcompanharVidAula;
using System;
using System.Globalization;

namespace Course
{
	class Program
	{
		static void Main(string[] args)
		{
			Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
			Console.Write("Nome: ");
			p.Nome = Console.ReadLine();
			Console.Write("Preço: ");
			p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
			p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDados do produto " + p);
            Console.Write("\nDigite o número de produtos a ser adicionado ao estoque: ");
			int qte = int.Parse(Console.ReadLine());
			p.AdicionarPodutos(qte);

            Console.WriteLine("\nDados atualizados: " + p);

			Console.Write("\nDigite o número de produtos a ser removido do estoque: ");
			qte = int.Parse(Console.ReadLine());
			p.RemoverPodutos(qte);

			Console.WriteLine("\nDados atualizados: " + p);
		}
	}
}