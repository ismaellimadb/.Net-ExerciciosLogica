﻿Console.WriteLine("Digite um numero inteiro:");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0){
    Console.WriteLine("O número " + numero + " é par");
}
else {
    Console.WriteLine("O número " + numero + " é impar");
}