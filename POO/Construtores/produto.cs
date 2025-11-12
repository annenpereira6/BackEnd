
namespace Construtores
{
    public class Produto
    {
        public string Nome;
        public float Preço;
        public int Estoque;

        public Produto(string n, float p, int e)
        {
            Nome = n;
            Preço = p;
            Estoque = e;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Produto: {Nome}, Preço: R${Preço:F2}, Quantidade estoque: {Estoque}");
        }
    }
}