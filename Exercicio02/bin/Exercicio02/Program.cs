// Faça um programa que o usuário informe o salário recebido e o total gasto. 
// Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário
//  e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.

 double salariorecebido, totalgastos;
 

Console.WriteLine($"Informe o salario: ");
salariorecebido = double.Parse(Console.ReadLine());
Console.WriteLine($"Informe o gasto do mes: ");
totalgastos = double.Parse(Console.ReadLine());



if (totalgastos <= salariorecebido)
{
    Console.WriteLine($"Gastos dentro do Orçamento");
}
else
{
    Console.WriteLine($"Orçamento Extourado");
}

Console.WriteLine();



