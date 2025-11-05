using System;

public class Produto
{
    public string Nome;
    public double Preco;

    public void AplicarDesconto(double percentual)
    {
        double desconto = Preco * (percentual / 100);
        Preco -= desconto;
        Console.WriteLine($"Desconto de {percentual}% aplicado! Novo preço: R${Preco:F2}");
    }
}

public class Program
{
    public static void Main()
    {
        Produto p1 = new Produto();
        p1.Nome = "Camisa";
    }
  }