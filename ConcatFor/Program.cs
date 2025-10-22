//perguntar ao usuario quantas letras tem o nome dele
//depois vamos pedir letra a letra de seu nome 
//ao final , vamos exibir o nome do usuario completo

int qtdLetras = 0;

Console.WriteLine($"Ola usuario, quantas letras tem o seu nome?");
qtdLetras = int.Parse(Console.ReadLine()); //guarda o numero da variavel
string nome = "";

for (int i = 1; i <= qtdLetras; i++)
{
    Console.WriteLine($"Qual é a {i}ª letra?");
    nome = nome + Console.ReadLine();
}

Console.WriteLine($"Seu nome é: {nome}");




   