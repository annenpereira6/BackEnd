
namespace Exercicios02;

    public class SaldoBancario
    {
        public int Numero;
        public float Saldo;

        public void Depositar(float valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de {valor} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor inválido para depósito!");
            }
        }

        public void Sacar(float valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor inválido ou saldo insuficiente!");
            }
        }
    }

 
    public class ContaPoupanca : SaldoBancario
    {
        public void CalcularRendimento()
        {
            float rendimento = Saldo * 0.02f; // 2%
            Saldo += rendimento;
            Console.WriteLine($"Rendimento de 2% aplicado! (+{rendimento})");
        }
    }