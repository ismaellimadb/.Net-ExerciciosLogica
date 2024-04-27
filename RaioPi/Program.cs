//RaioPi
double pi = Convert.ToDouble(Math.PI.ToString("#.#####"));
string raio;
double area;

Console.WriteLine("Digite o Raio:");
raio = Console.ReadLine();

area = pi * Math.Pow(Convert.ToDouble(raio), 2);

Console.WriteLine("Area = " + area);
Console.Read();