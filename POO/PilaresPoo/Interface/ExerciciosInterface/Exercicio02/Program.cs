using System.Data;
using System.Reflection;
using Exercicio02;
// List<Fatura> listafatura = new List<Fatura>();
// List<Relatorio> listaRelatorio = new List<Relatorio>();
// List<Contrato> listaContrato = new List<Contrato>();
List<IImprimivel> Documentos = new List<IImprimivel>();

int opcao;

do
{
    Console.Clear();
    Console.WriteLine($@"====== Menu de opções ======
    
    1) Cadastrar Fatura
    2) Cadastrar Relatório
    3) Cadastrar Contrato
    4) Listas Faturas
    5) Listar Relatórios
    6) Listar Contratos
    0) Sair");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            CadastrarFaturas();
            break;

        case 2:
            Console.WriteLine($"Cadastrar Relatório em desenvolvimento");
            break;

        case 3:
            Console.WriteLine($"Cadastrar Contratos em desenvolvimento");
            break;

        case 4:
            ListarFaturas();
            break;

        case 5:
            Console.WriteLine($"Listar Relatórios em desenvolvimento");
            break;

        case 6:
            Console.WriteLine($"Listar Contratos em desenvolvimento");
            break;

        case 0:
            Console.WriteLine($"Sair");
            break;

        default:
            Console.WriteLine($"Opção Inválida");
            break;

    }

    Console.WriteLine($"Pressione <<Enter>> para continuar");
    Console.ReadLine();

} while (opcao != 0);



void CadastrarFaturas()
{
    Console.WriteLine($"Digite o nome do cliente devedor");
    string dev = Console.ReadLine();

    Console.WriteLine($"Digite o nome da empresa");
    string empresa = Console.ReadLine();

    Console.WriteLine($"Digite o valor da fatura");
    float Valor = float.Parse(Console.ReadLine());

    Console.WriteLine($"Dias de atraso da fatura");
    int QtdDiasAtraso = int.Parse(Console.ReadLine());
    
    Fatura fat = new Fatura(dev, empresa, Valor, QtdDiasAtraso);
    Documentos.Add(fat);
}

void CadastrarRelatorio()
{
       Console.Write($"Digite o Nome do Responsavel:");
    string nome = Console.ReadLine();

    Console.Write($"Digite o Texto Relatorio:");
    string TX = Console.ReadLine();

    Relatorio relatorio = new Relatorio();
    relatorio.NomeResponsavel = nome;
    relatorio.TextoRelatorio =  TX;
    Documentos.Add(relatorio);
    Console.WriteLine($"Relatorio cadastrado com sucesso!");
    
}

void CadastrarContrato()
{
     Console.WriteLine($"Digite o Nome:");
    string Nome = Console.ReadLine();

    Console.WriteLine($"Digite o Texto Clausula:");
    string TX = Console.ReadLine();
    Contrato contrato = new Contrato();
    contrato.Nome = Nome;
    contrato.textoClausulas = TX;
    Documentos.Add(contrato);
    Console.WriteLine($"contrato cadastrado com sucesso!");
    
}


void ListarFaturas()
{
    Console.WriteLine($"Listando Faturas:");
    foreach (var item in Documentos)
    {
        if (item is Fatura)
        {
            item.Imprimir();
        }
    }
}

void ListarRelatorios()
{
    {
        Console.WriteLine($"Listando Relatorios:");
    foreach (var item in Documentos)
    {
       if (item is Relatorio)
       {
            item.Imprimir();
       } 
    }
}
}

void ListarContrato()
{
    {
            Console.WriteLine($"Listando Contrato:");
    foreach (var item in Documentos)
    {
       if (item is Contrato)
       {
            item.Imprimir();
       } 
    }
    
}
}


