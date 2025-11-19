

namespace Exercicio1
{
    public class Retangulo : IForma
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public double CalcularArea()
    {
        return Largura * Altura;
    }
}
}