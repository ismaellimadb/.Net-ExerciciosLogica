int x;
int dentro = 0;
int fora = 0;
Console.WriteLine("Digite um numero inteiro para continuar:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite os valores conforme escolhido pelo numero digitado: " + n);
for (int i = 0; i < n; i++)
{
    x = Convert.ToInt32(Console.ReadLine());
    if(x >= 10 && x <= 20){
        dentro++;
    }
    else {
        fora++;
    }
}

Console.WriteLine("Resultado:\n" + dentro + " in\n" + fora + " out");