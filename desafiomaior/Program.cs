//pedir para o usuario digitar dois numeros em seguida verificar e exibir qual é o maior dos dois numeros

int primeironumero;
int segundonumero;

Console.WriteLine($"Digite o primeiro numero");
primeironumero = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo numero");
segundonumero = int.Parse(Console.ReadLine());

if (primeironumero > segundonumero)
{
 Console.WriteLine($"O primeiro numero é maior: {primeironumero}");
}
else
{
  Console.WriteLine($"O segundo numero é maior: {segundonumero}");
}
