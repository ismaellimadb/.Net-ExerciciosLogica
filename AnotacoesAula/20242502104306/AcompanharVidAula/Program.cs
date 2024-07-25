using System;
class Program
{
	static void Main()
	{
        Console.WriteLine("Qual a hora atual?");
		int hora = int.Parse(Console.ReadLine());
		
		if (hora < 12)
		{
            Console.WriteLine("Bom dia");
        }
		else if (hora < 18)
		{
			Console.WriteLine("Boa tarde");
		}
		else
		{
			Console.WriteLine("Boa noite!");
		}
		//com ekse if para de testar o programa, com else if ja para de testar alem de ser mais seguro com else if pois um if so tem mais chande de erro.
		//if (hora >= 12 && hora < 18)
		//{
		//          Console.WriteLine("Boa tarde");
		//      }
		//if (hora >= 18)
		//{
		//	Console.WriteLine("Boa noite!");
		//}
	}
}