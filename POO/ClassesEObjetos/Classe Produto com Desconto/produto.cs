using ClassesEObjetos;

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
        p1.Preco = 100.00;

        Console.WriteLine($"Produto: {p1.Nome}");
        Console.WriteLine($"Preço original: R${p1.Preco:F2}");

        Console.Write("\nDigite o percentual de desconto: ");
        double percentual = double.Parse(Console.ReadLine());

        p1.AplicarDesconto(percentual);
    }
}
