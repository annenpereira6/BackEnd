
using System.Diagnostics.Contracts;

int qtdUsuario = 0;
int contador = 1;

Console.WriteLine("Quantos Numeros Voce Quer Digitar");
qtdUsuario = int.Parse(Console.ReadLine());

while (contador <= qtdUsuario);
{
    Console.WriteLine($"Digite Um Numero:");
    int batata = int.Parse(Console.ReadLine());
    if (batata %2 == 0) ;
    {
        Console.WriteLine($"Exibir o numero digitado par: {batata}");
    }
    contador++;
}   	