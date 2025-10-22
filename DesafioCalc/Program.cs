//Pedir para o usuario digitar dois numeros e exibir a soma desses dois numeros

using System.Runtime.InteropServices;

int primeironumero;
int segundonumero;

Console.WriteLine($"Digite o primeiro numero");
primeironumero = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo numero");
segundonumero = int.Parse(Console.ReadLine());

int soma = primeironumero + segundonumero;

Console.WriteLine($"A soma de {primeironumero} + {segundonumero} é {soma}");
