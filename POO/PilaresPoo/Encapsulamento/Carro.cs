
using System.Runtime.InteropServices;

namespace Encapsulamento
{
    public class Carro
    {
        string Marca;
        string Modelo;
        int Velocidade;
      
      //set
       public void DefinirMarca(string valor)
        {
            Marca = valor;
        }
       //get
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
            if(valor > 0)
            {
                 Velocidade += valor;
            }
           Console.WriteLine($"Nao pode acelerar negativamente!");

        }

        public void Frear(int valor)
        {
            Velocidade -= valor;

            if (Velocidade < 0)
            {
                Velocidade = 0;
            }

           
        }
    }
   }
