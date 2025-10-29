string[] nomes = new string[4];

nomes[0] = "Anne";
nomes[1] = "Maria";
nomes[2] = "Rafa";

Console.WriteLine($"Tamanho do Arrays: {nomes.Length}");

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($" {i + 1}o Nome: {nomes[i]} ");
    
}

