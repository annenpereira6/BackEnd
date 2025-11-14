
namespace Heranca
{
    public class Moto : Veiculo
    {
       public int Velocidade;
         
        public void somMoto()
        {
            Console.WriteLine($"Vrumm...Vrumm");
            
        }
         
         public void ExibirInfo()
        {
             Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Velocidade : {Velocidade}");
            Console.WriteLine();
            
        }
    }
}