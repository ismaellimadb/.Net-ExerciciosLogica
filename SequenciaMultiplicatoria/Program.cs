Console.WriteLine("Digite um valor numero inteiro para ser sequenciado:");
int sequencia = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= sequencia; i++)
{
    Console.WriteLine($"{i} x {sequencia} = {i*sequencia}");
}