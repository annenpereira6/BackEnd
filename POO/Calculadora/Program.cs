// using Calculadora;

// Console.Clear();

// Calculator calc = new Calculator();

// calc.Numero1 = 50;
// calc.Numero2 = 10;

// Console.WriteLine($"== Calculator ==");
// Console.WriteLine($"primeiro numero: {calc.Numero1}");
// Console.WriteLine($"segundo numero: {calc.Numero2}");

// Console.WriteLine($"Resultados:");
// Console.WriteLine();


// Console.WriteLine($"Soma {calc.Somar()}");
// calc.Somar();
// Console.WriteLine();

// Console.WriteLine($"Subtração {calc.Subtrair()}");
// calc.Subtrair();
// Console.WriteLine();

// Console.WriteLine($"Multiplicação {calc.Multiplicar()}");
// calc.Multiplicar();
// Console.WriteLine();

// Console.WriteLine($"Divisão {calc.Dividir()}");
// calc.Dividir();
// Console.WriteLine();

using Calculadora;

Calculator calc = new Calculator();
            int opcao = 0;

            while (opcao != 5)
            {
                Console.WriteLine("=== CALCULADORA ===");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o primeiro número: ");
                        calc.Numero1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        calc.Numero2 = double.Parse(Console.ReadLine());
                        calc.Somar();
                        break;

                    case 2:
                        Console.Write("Digite o primeiro número: ");
                        calc.Numero1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        calc.Numero2 = double.Parse(Console.ReadLine());
                        calc.Subtrair();
                        break;

                    case 3:
                        Console.Write("Digite o primeiro número: ");
                        calc.Numero1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        calc.Numero2 = double.Parse(Console.ReadLine());
                        calc.Multiplicar();
                        break;

                    case 4:
                        Console.Write("Digite o primeiro número: ");
                        calc.Numero1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        calc.Numero2 = double.Parse(Console.ReadLine());
                        calc.Dividir();
                        break;

                    case 5:
                        Console.WriteLine("Encerrando o programa...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida, tente novamente.\n");
                        break;
                }
            }
