

namespace Exercicio1
{
  public class Circulo : IForma
{
    public double Raio { get; set; }

    public void CalcularArea()
    {
        return Math.PI * Raio * Raio;
    }
}

}