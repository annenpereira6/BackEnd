int opção = -1;

do
{
 Console.Clear();
Console.WriteLine($"-------------------------");
Console.WriteLine($"     Bem Vindo           ");
Console.WriteLine($"         ao              ");
Console.WriteLine($"    Jacareca food        ");
Console.WriteLine($"-------------------------");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"Escolha uma opção no menu abaixo:");
Console.WriteLine();
Console.WriteLine($"  1)    HotRoll  ----------------  R$ 29,90 ");
Console.WriteLine($"  2)    Temaki    ----------------  R$ 30,00 ");
Console.WriteLine($"  3)    Sashimi   ----------------  R$ 67,20 ");
Console.WriteLine($"  4)    Yakisoba  ----------------  R$ 35,90 ");
Console.WriteLine($"  5)    Guioza    ----------------  R$ 49,90 ");
Console.WriteLine($"  6)    Shimeji   ----------------  R$ 50,90 ");
Console.WriteLine($"  0)    Sair");
Console.WriteLine($"Opção: ");
opção = int.Parse(Console.ReadLine() );


switch (opção)
{
    case 0:
        Console.WriteLine($"Saindo...");

        break;
    case 1:
            HotRoll();
        break;
    case 2:
            Temaki();
        break;
    case 3:
            Sashimi();
        break;
    case 4:
            Yakisoba();
        break;
    case 5:
            Guioza();
        break;
    case 6:
            Shimeji();
        break;
    default:
        Console.WriteLine($"Opção Invalida");
        break;
}

Console.WriteLine($"Digite <Enter> para continuar...");
Console.ReadLine();
} while (opção != 0) ;


void HotRoll()
{
 Console.WriteLine($"Boa Escolha, vamos preprar seu HotRoll com carinho");
}

void Temaki()
{
    Console.WriteLine($"Boa Escolha, vamos preprar seu Temaki com carinho");
}

void Sashimi()
{
    Console.WriteLine($"Boa Escolha, vamos preprar seu Sashimi  com carinho");
}

void Yakisoba ()
{
    Console.WriteLine($"Boa Escolha, vamos preprar seu Yakisoba  com carinho");
}

void Guioza()
{
    Console.WriteLine($"Boa Escolha, vamos preprar seu Guioza  com carinho");
}

void Shimeji ()
{
     Console.WriteLine($"Boa Escolha, vamos preprar seu Shimeji  com carinho");
}
