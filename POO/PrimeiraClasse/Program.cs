using PrimeiraClasse;

Console.WriteLine($"==== PROGRAMA PRIMEIRA CLASSE ====");

// Carro mclaren = new Carro();
// mclaren.marca = "Mclaren";
// mclaren.cor = "Laranja";
// mclaren.modelo = "750s";
// mclaren.potencia = 800;

// Console.WriteLine($"Ligando a {mclaren.marca} {mclaren.cor}");
// mclaren.Ligar();
// Console.WriteLine($"Acelerando a {mclaren.marca} de {mclaren.potencia} cv");
// mclaren.Acelerar();


//Pessoa anne = new Pessoa();
//anne.Nome = "Anne Nicole";
//anne.Idade = 17;
//anne.Altura = 165;

//anne.Falar();
//anne.Dormir();

Console.Clear();
Pessoa anne = new Pessoa();
anne.Nome = "Anne Nicole";
anne.Altura = 165;
anne.Envelhecer();//1

Console.WriteLine($"{anne.Nome} tem {anne.Idade}");
anne.Envelhecer(10);
Console.WriteLine($"{anne.Nome} tem {anne.Idade}");




