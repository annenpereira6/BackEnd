
using System.Runtime.InteropServices;

namespace Encapsulamento
{
    public class Carro
    {
        string Marca;
        string Modelo;
        int Velocidade;

       public void DefinirMarca(string valor)
        {
            Marca = valor;
        }

        public string ObterMarca()
        {
            return Marca;
        }

        
        public void DefinirModelo(string valor)
        {
           Modelo = valor;
        }

        public string ObterModelo()
        {
            return Modelo;
        }

       
        public int ObterVelocidade()
        {
            return Velocidade;
        }

        public void Acelerar(int valor)
        {
            Velocidade += valor;
            Console.WriteLine($"Acelerou +{valor}. Velocidade : {Velocidade} km/h");
        }

        public void Frear(int valor)
        {
            Velocidade -= valor;

            if (Velocidade < 0)
            {
                Velocidade = 0;
            }

            Console.WriteLine($"Freou -{valor}. Velocidade : {Velocidade} km/h");   
        }
    }
   }
