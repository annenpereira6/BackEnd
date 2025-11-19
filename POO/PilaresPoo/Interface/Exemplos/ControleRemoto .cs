
namespace Exemplos
{
    public class ControleRemoto : IControle
    {
        public int NivelVolume = 0;
        public int VolumeMaximo = 30;
       

        public void AumentarVolume()
        {
            if(NivelVolume == VolumeMaximo)
            {
                Console.WriteLine($"Volume maximo atingido {NivelVolume}");
                return;
            }
            NivelVolume++;
            Console.WriteLine($"Aumentando Volume: {NivelVolume}");

        }

        public void Desligar()
        {
            Console.WriteLine($"Desligando a tv...");

        }

        public void DiminuirVolume()
        { 
            if (NivelVolume == 0)
            {
                Console.WriteLine($"Volume ja esta no minimo: {NivelVolume}");
                return;
            }
            NivelVolume--;
            Console.WriteLine($"Diminuindo Volume...");

        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando...");

        }
    }
}