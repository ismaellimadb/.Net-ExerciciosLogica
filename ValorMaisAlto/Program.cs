int i = 0;
int[] num = new int[3];
Console.WriteLine("Digite 3 números Inteiros:");
while (i < 3) { 
    num[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}

Console.WriteLine($"Valor mais alto: {num.Max()}");