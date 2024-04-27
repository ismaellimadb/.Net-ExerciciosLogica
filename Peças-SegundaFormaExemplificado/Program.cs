int i = 0;
double[] qtd = new double[2];
double[] valor = new double[2];
double total;
Console.WriteLine("Digite o codigo, a quantidade e o valor para duas peças");
while (i < 2) {
    Console.ReadLine();
    qtd[i] = Convert.ToDouble(Console.ReadLine());
    valor[i] = Convert.ToDouble(Console.ReadLine());
    i++;
}

total = (qtd[0] * valor[0]) + (qtd[1] * valor[1]);

Console.WriteLine($"Valor a pagar: {total}");