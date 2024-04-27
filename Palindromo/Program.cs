using System.Text.RegularExpressions;

Console.WriteLine("Digite uma palavra ou frase:");
string palin = Console.ReadLine();
string formataPalin = Regex.Replace(palin, @"[^\w]", string.Empty);
string dromo = new string(formataPalin.Reverse().ToArray());
if (formataPalin.ToLower() == dromo.ToLower()){
    Console.WriteLine($"{palin} é um palindromo");
}
else{
    Console.WriteLine($"{palin} não é palindromo pois de traz pra frente fica: {dromo}");
}