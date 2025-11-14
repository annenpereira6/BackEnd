
namespace Exercicios02

{
    public class Veiculo
    {
        public string Marca;
        public string Modelo;

        public virtual void MostrarInfo()
        {
            Console.WriteLine("Informações do veículo:");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
        }
    }

    
    public class Carro : Veiculo
    {
        public int QtdPortas;

        public override void MostrarInfo()
        {
            Console.WriteLine("=== Carro ===");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Quantidade de portas: {QtdPortas}");
        }
    }

    public class Moto : Veiculo
    {
        public string TipoCapacete;

        public override void MostrarInfo()
        {
            Console.WriteLine("=== Moto ===");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Tipo de capacete: {TipoCapacete}");
        }
    }
    }
