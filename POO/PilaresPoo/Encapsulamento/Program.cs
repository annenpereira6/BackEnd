using Encapsulamento;

// ContaBancaria contaAnne = new ContaBancaria();
// ContaBancaria contaMaria = new ContaBancaria(1500);

// contaAnne.Saldo = -100;
// contaAnne.Depositar(20);
// contaAnne.Sacar(-200);
// contaMaria.Sacar(300);

// Console.WriteLine();

// Console.WriteLine($"Saldo atual: R${contaAnne.GetSaldo()}");


 {
        static void Main(string[] args)
        {
            Carro carro = new Carro()
            carro.DefinirMarca("Hyundai");
            carro.DefinirModelo(" IONIQ 5");
            carro.Acelerar(40);
            carro.Acelerar(30);
            carro.Frear(24);
            carro.Frear(15); 

        
            Console.WriteLine("=== DADOS DO CARRO ===");
            Console.WriteLine("Marca: " + carro.ObterMarca());
            Console.WriteLine("Modelo: " + carro.ObterModelo());
            Console.WriteLine("Velocidade : " + carro.ObterVelocidade() + " km/h");
        }
    }


