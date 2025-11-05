

using System.Security.Cryptography.X509Certificates;

namespace ClassesEObjetos;

using System;

public class ContaBancaria
{
    public string Titular;
    public double Saldo;

    public void Depositar(float valor)
    {
        Saldo += valor;
        Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso!");
        Console.WriteLine($"Saldo atual: R$ {Saldo:F2}");
    }

    public void Sacar(float valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para o saque!");
        }
        Console.WriteLine($"Saldo atual: R$ {Saldo:F2}");
    }
}

public class Program
{
    public static void Main()
    {
        ContaBancaria conta = new ContaBancaria();

        Console.Write("Digite o nome do titular da conta: ");
        conta.Titular = Console.ReadLine();

        Console.WriteLine($"\nBem-vindo(a), {conta.Titular}!");
        Console.WriteLine($"Saldo inicial: R$ {conta.Saldo:F2}");

        conta.Depositar(500);   // Exemplo de depósito
        conta.Sacar(200);       // Exemplo de saque
        conta.Sacar(400);       // Exemplo de saque com saldo insuficiente
    }
}
