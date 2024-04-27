Console.WriteLine("Digite um numero inteiro:");
int primo = Convert.ToInt32(Console.ReadLine());

if (Enumerable.Range(1, primo).Where(x => primo%x == 0).SequenceEqual(new[] {1, primo})){
    Console.WriteLine($"{primo} É primo");
}
else{
    Console.WriteLine($"{primo} Não é primo");
}