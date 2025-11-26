using Exercicio1;
Console.WriteLine("=== EXERCÍCIO 1 - Formas ===");
Console.Write("Informe a largura do retângulo: ");
float largura = float.Parse(Console.ReadLine());
Console.Write("Informe a altura do retângulo: ");
float altura = float.Parse(Console.ReadLine());
Retangulo retangulo = new Retangulo
{
    Largura = largura,
    Altura = altura
};
Console.WriteLine($"Área do Retângulo = {retangulo.CalcularArea()}");
Console.WriteLine("Informe o raio do círculo: ");
float raio = float.Parse(Console.ReadLine());
Circulo circulo = new Circulo
{
    Raio = raio
};
Console.WriteLine($"Área do Círculo = {circulo.CalcularArea()}");