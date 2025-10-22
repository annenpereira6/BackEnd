//Faca um programa que receba 4 notas de um aluno, calcule e imprima a média aritmética das notas e a mensagem de Aprovado para 
// média superior ou igual a 7,0 RECUPERACAO para notas entre 5.0 e 7,0 ou a mensagem de REPROVADO para média inferior a 5,0.

using System.Net.Http.Headers;

float primeiranota;
 float segundanota;
 float terceiranota;
 float quartanota;

Console.WriteLine($"Digite a primeira nota");
primeiranota = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a segunda nota");
segundanota = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a terceira nota");
terceiranota = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a quarta nota");
quartanota = float.Parse(Console.ReadLine());

media = (primeiranota + segundanota + terceiranota + quartanota) / 4;

Console.WriteLine($"Media: {media}");

if (media >= 7)
{
    Console.WriteLine($"Aprovado");
}
else if
{
    Console.WriteLine($"Recuperacao");
}
else
{
    Console.WriteLine($"Reprovado");
}
