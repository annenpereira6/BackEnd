
using Exemplos;
using Exemplosp;

// Gato birobinha = new Gato();
// Cachorro Mel = new Cachorro();
// Pessoa Anne = new Pessoa();

// Anne.Nome = "Anne Nicole";
// Anne.Idade = 17;

// Anne.FazerSom();
// Anne.Mover();
// Anne.Dormir();


// Console.WriteLine($"Nome: {Anne.Nome}");
// Console.WriteLine($"Idade da {Anne.Nome}: {Anne.Idade} anos");

// Console.WriteLine($"Som do {Anne.Nome}: ");
// Anne.FazerSom();
// Console.WriteLine($"{Anne.Nome} esta se movendo: ");
// Anne.Mover();

// Console.WriteLine($"{Anne.Nome} foi dormir: ");
// Anne.Dormir();

Console.Clear();
ContaCorrente cc = new ContaCorrente(10);
Console.WriteLine($"Saldo inicial da conta: {cc.saldo}");
cc.Depositar(0.5);
Console.WriteLine($"Saldo apos deposito: R${cc.saldo}");
cc.Sacar(10.01);
Console.WriteLine($"Saldo apos o saque: R${cc.saldo}");


cc.Sacar(10);










