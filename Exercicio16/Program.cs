
//producao - 6.5
//administrativo -7.5
//diretoria - 12

//salario = salario * 1 .065
//salario = salario * 1 .075
//salario = salario * 1 .12

// De acordo com a tabela acima faça um programa que receba a cargo e o salario de um funcionario e calcule 
//e imprima o salario reajustado.

 string cargo;
 double salario, salarioNovo;

Console.WriteLine($"Digite o cargo do funcionario producao, administrativo ou diretoria");
cargo = Console.ReadLine();

Console.WriteLine($"Digite o salario do funcionario");
salario = double.Parse(Console.ReadLine());

if (cargo == "producao")
{
    salarioNovo = salario + (salario * 0.065);

}

else if (cargo == "administrativo")
{
    salarioNovo salario +(salario * 0.075
    )
}

else if (cargo == "diretoria")
{
    salarioNovo salario +(salario * 0.12)

}

else
{
    Console.WriteLine($"cargo invalido");

}

Console.WriteLine()