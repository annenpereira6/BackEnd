using ClassesEObjetos;

//Console.Clear();
//Console.WriteLine(== Agencia Bancária ==);
//Console.WriteLine();

//Agencia Bancaria contaDaAnne = new AgenciaBancaria();

//contaDaAnne.Titular = "Anne Nicole";
//contaDaAnne.saldo = 1000.98f;

//contaDaAnne.Depositar(-5000);

//contaDaAnne.Sacar(90000);


//Console.Clear();
//Console.WriteLine("== Produto com Desconto ==");
//Console.WriteLine();


//Console.Clear();
//Console.WriteLine("== Produto com Desconto ==");
//Console.WriteLine();

Produto produto1 = new Produto();

produto1.Nome = "Camisa";
produto1.Preco = 120.00f;

produto1.AplicarDesconto(10); // aplica 10% de desconto
produto1.AplicarDesconto(50); // aplica mais 50% de desconto

public class Produto
{
    public string Nome;
    public float Preco;

    public void AplicarDesconto(float percentual)
    {
        if (percentual <= 0 || percentual > 100)
        {
            Console.WriteLine("Percentual de desconto inválido!");
            return;
        }

        float desconto = Preco * (percentual / 100);
        Preco -= desconto;

        Console.WriteLine($"Desconto de {percentual}% aplicado!");
        Console.WriteLine($"Novo preço do produto '{Nome}': R${Preco:F2}\n");
    }
}
