
// // class Program
// // {
// //     static void Main(string[] args)
// //     {
// //         Funcionario funcionario = new Funcionario("Rafa", 300);
// //         Gerente gerente = new Gerente("Anne", 5000, 200);

// //         Console.WriteLine($"Funcionário: {funcionario.Nome}, Salário: {funcionario.CalcularSalario():C}");
// //         Console.WriteLine($"Gerente: {gerente.Nome}, Salário: {gerente.CalcularSalario():C}");
// //     }
// // }

// // using Exercicios02;

// // class Program
// //     {
// //         static void Main(string[] args)
// //         {
// //             Carro carro1 = new Carro();
// //             carro1.Marca = "Toyota";
// //             carro1.Modelo = "Corolla";
// //             carro1.QtdPortas = 4;

// //             Moto moto1 = new Moto();
// //             moto1.Marca = "Honda";
// //             moto1.Modelo = "CG 160";
// //             moto1.TipoCapacete = "Fechado";

// //             // Exibindo informações
// //             carro1.MostrarInfo();
// //             Console.WriteLine();
// //     //         moto1.MostrarInfo();

// //     //         Console.ReadKey();
// //     //     }
// //     // }

// using Exercicios02;

// class Program
//     {
//         static void Main(string[] args)
//         {
//             Aluno aluno1 = new Aluno();
//             aluno1.Nome = "Lucas";
//             aluno1.Idade = 20;
//             aluno1.Curso = "Engenharia";

//             Professor professor1 = new Professor();
//             professor1.Nome = "Marta";
//             professor1.Idade = 35;
//             professor1.Disciplina = "Matemática";

//             aluno1.MostrarInfo();
//             Console.WriteLine();
//             professor1.MostrarInfo();

//             Console.ReadKey();
//         }
//     }

using Exercicios02;

class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca conta = new ContaPoupanca();

            conta.Numero = 123;
            conta.Saldo = 0;

            Console.WriteLine("=== Conta Poupança ===");
            Console.WriteLine($"Saldo inicial: {conta.Saldo}");

            conta.Depositar(1000);
            Console.WriteLine($"Saldo após depósito: {conta.Saldo}");

            conta.CalcularRendimento();
            Console.WriteLine($"Saldo após rendimento: {conta.Saldo}");

            Console.ReadKey();
        }
    }
