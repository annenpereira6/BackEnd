
using System.Security.Cryptography.X509Certificates;

namespace Exercicio02
{
    public class Contrato : IImprimivel
    {   public string Nome;
        public string textoClausulas;
        public void Imprimir()
        {
            
           Console.WriteLine($@"
           Contratante: {Nome}
           Clausulas: {textoClausulas}
            ");
           
        }

    }
}

 