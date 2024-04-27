string cod;
string quatidade;
double preco = 0;
double total;

Console.WriteLine("Digite o codigo do seu pedido no Cardapio:\n1 - Cachorro Quente: R$ 4,00\n2 - X-Salada R$ 4,50\n3 - X-Bacon R$ 5,00\n4 - Torrada simples R$ 2,00\n5 - Refrigerante R$ 1,50");
cod = Console.ReadLine();
Console.WriteLine("Digite a quatidade para o pedido.");
quatidade = Console.ReadLine();

switch(cod)
{
    case "1" :
        preco = 4;
    break;

    case "2" :
        preco = 4.50;
    break;

    case "3" :
        preco = 5;
    break;

    case "4" :
        preco = 2;
    break;

    case "5" :
        preco = 1.50;
    break;
}

total = preco * Convert.ToInt32(quatidade);

Console.WriteLine("Seu pedido ira custar: R$ " + total.ToString("0.00"));
Console.Read();