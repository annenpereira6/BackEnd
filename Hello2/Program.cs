//pedir para o usuário digitar o nome, sobrenome, idade, saldo bancario e quanto investiu esse ano

//Camel case - Letra maiuscula a partir da segunda palavra
string nome;
string sobrenome;
int idade;
float SaldoBancario;
float investimentos;

//Pasca Case - Primeira letra de cada palavra sempre maiuscula
Console.WriteLine("Olá, qual é o seu nome?");
nome = Console.ReadLine();

Console.WriteLine("Qual é seu sobrenome?");
sobrenome = Console.ReadLine();

Console.WriteLine("Qual é a sua idade?");
idade = int.Parse(Console.ReadLine());//converte o texto em int antes de jogar na variável

Console.WriteLine("qual é o seu saldo bancario?");
SaldoBancario = float.Parse(Console.ReadLine()); //converte o texto digitando no console em float

//receber o investimento do usuário

Console.WriteLine("Qual é investimentos para esse ano?");
investimentos = float.Parse(Console.ReadLine());

Console.Clear();//limpa o console
Console.WriteLine($"Nome: {nome} {sobrenome}");
Console.WriteLine($"Idade do {nome} é {idade}");
Console.WriteLine($"Saldo Bancario {SaldoBancario}");
Console.WriteLine($"Investimento este ano {investimentos}");