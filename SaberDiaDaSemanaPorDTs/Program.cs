using System.Globalization;

Console.WriteLine("Digite uma data no formato DD/MM/AAAA");
string date = Console.ReadLine();
DateTime dia = DateTime.Parse(date);
Console.WriteLine("O dia da semena é: " + dia.ToString("ddd", new CultureInfo("pt-BR")));