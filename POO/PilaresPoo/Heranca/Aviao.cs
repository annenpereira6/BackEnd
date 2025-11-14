
namespace Heranca
{

    public class Aviao : Veiculo
    {
        public int QtdAssentos;

        public void Voar()
        {
            Console.WriteLine($"Aviao Levantou");
            
            Console.WriteLine($"tecoteco...tecoteco");
            
        }
         
         public void ExibirInfo()
        {
             Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Quantos Assentos: {QtdAssentos}");
            Console.WriteLine();
            
        }
    }
}