using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite os coeficientes a, b e c da equação ax^2 + bx + c = 0:");

        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double delta = b * b - 4 * a * c;

        if (a == 0)
        {
            Console.WriteLine("Coeficiente 'a' não pode ser zero. Não é uma equação do segundo grau.");
        }
        else if (delta < 0)
        {
            Console.WriteLine("Impossível calcular. O discriminante (delta) é negativo.");
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"Raízes da equação:");
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        }
    }
}