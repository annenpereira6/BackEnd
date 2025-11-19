

namespace Exercicio1
{
  public class Circulo : IForma
{
    public double Raio { get; set; }

    public double CalcularArea()
    {
        return Math.PI * Raio * Raio;
    }
}

}