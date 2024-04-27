/*Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago
*/

string cod;
double preco = 0;
string qtd;
double valor = 0;
double resultado;

Console.WriteLine("Escolha um codigo de peça e a quantidade de peças de acordo com os valores abaixo:");
Console.WriteLine("Peça cod 1: R$ 15.10");
Console.WriteLine("Peça cod 2: R$ 15.10");
Console.WriteLine("Peça cod 12: R$ 5.30");
Console.WriteLine("Peça cod 13: R$ 15.30");
Console.WriteLine("Peça cod 16: R$ 5.10");
Console.WriteLine("Peça cod 161: R$ 5.20");
cod = Console.ReadLine();

switch (cod)
{
	case "1":
		preco = 15.10;
		break;
	case "2":
		preco = 15.10;
		break;
	case "12":
		preco = 5.30;
		break;
	case "13":
		preco = 15.30;
		break;
	case "16":
		preco = 5.10;
		break;
	case "161":
		preco = 5.20;
		break;
	default:
		Console.WriteLine("Digite um valor valido!!!");
		break;
}

Console.WriteLine("Digite a quantidade");
qtd = Console.ReadLine();

try
{
	valor = preco * Convert.ToInt32(qtd);
}
catch
{
    Console.WriteLine("Digite um calculo valido!!!");
}

string cod2;
double preco2 = 0;
string qtd2;
double valor2 = 0;

Console.WriteLine("Escolha outro codigo de peça e a quantidade de peças de acordo com os valores abaixo:");
Console.WriteLine("Peça cod2 1: R$ 15.10");
Console.WriteLine("Peça cod2 2: R$ 15.10");
Console.WriteLine("Peça cod2 12: R$ 5.30");
Console.WriteLine("Peça cod2 13: R$ 15.30");
Console.WriteLine("Peça cod2 16: R$ 5.10");
Console.WriteLine("Peça cod2 161: R$ 5.20");
cod2 = Console.ReadLine();

switch (cod2)
{
	case "1":
		preco2 = 15.10;
		break;
	case "2":
		preco2 = 15.10;
		break;
	case "12":
		preco2 = 5.30;
		break;
	case "13":
		preco2 = 15.30;
		break;
	case "16":
		preco2 = 5.10;
		break;
	case "161":
		preco2 = 5.20;
		break;
	default:
		Console.WriteLine("Digite um valor2 valido!!!");
		break;
}

Console.WriteLine("Digite a quantidade");
qtd2 = Console.ReadLine();

try
{
	valor2 = preco2 * Convert.ToInt32(qtd2);
}
catch
{
	Console.WriteLine("Digite um calculo valido!!!");
}

resultado = valor + valor2;

Console.WriteLine("Você irá pagar:\n" + resultado);

Console.Read();