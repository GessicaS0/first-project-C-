// Screen sound - app de musicas 

//fortemente tipado, criar tipo de todas as variaveis 

//"" sempre aspas duplas

// colocar a string da forma que ela é usar @ na frente
using System.ComponentModel;
using System.Globalization;

string msg = "\nBoas vindas ao TIC TIC SOUND";


Dictionary<string, List<int>> registroDeBandas = new Dictionary<string, List<int>>();

registroDeBandas.Add("Linkin Park", new List<int> { 30, 38, 30 });
registroDeBandas.Add("Calcinha Preta", new List<int> { 12, 10, 10 });
registroDeBandas.Add("Calypso", new List<int> { 5, 5, 7 });
void ExibirLogo()
{
    Console.WriteLine(@"
████████╗██╗░█████╗░  ████████╗██╗░█████╗░  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
╚══██╔══╝██║██╔══██╗  ╚══██╔══╝██║██╔══██╗  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
░░░██║░░░██║██║░░╚═╝  ░░░██║░░░██║██║░░╚═╝  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░░░██║░░░██║██║░░██╗  ░░░██║░░░██║██║░░██╗  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
░░░██║░░░██║╚█████╔╝  ░░░██║░░░██║╚█████╔╝  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
░░░╚═╝░░░╚═╝░╚════╝░  ░░░╚═╝░░░╚═╝░╚════╝░  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(msg);
}

void Exibir_OP_Menu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\n Digite a opção desejada: ");
    string op = Console.ReadLine()!;
    int op_Escolhida = int.Parse(op);

    switch (op_Escolhida)
    {
        case 1: RegistrarBandas();
            break;
        case 2: MostrarBandas();
            break;
        case 3: AvaliaBanda();
            break;
        case 4: CalculaMediaBanda();
            break;
        case -1: Console.WriteLine("Saindo..... *");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}
void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloOP("Registro das Bandas");
    Console.Write("Informe o nome da banda para registro:  ");
    string nomeBanda = Console.ReadLine()!;
    registroDeBandas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"\nA banda {nomeBanda} foi registrada com sucesso!!");
    Thread.Sleep(2000);
    Console.Clear();
    Exibir_OP_Menu();
}

void MostrarBandas()
{
    Console.Clear();
    ExibirTituloOP("Listagem de todas as Bandas na Base");
    //para cada banda na minha lista de bandas
    foreach (string banda in registroDeBandas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal!");
    Console.ReadKey();
    Console.Clear();
    Exibir_OP_Menu();
}

void ExibirTituloOP(String titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");

}

void AvaliaBanda()
{

    Console.Clear();
    ExibirTituloOP("Avalie sua banda");
    Console.Write("Digite o nome da banda que deseja avaliar:  ");
    string nomeDaBanda = Console.ReadLine();

    if (registroDeBandas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"\nQual a nota que a banda {nomeDaBanda} merece ???\n");
        int nota = int.Parse(Console.ReadLine()!);
        registroDeBandas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
        Exibir_OP_Menu();



    }
    else
    {
        Console.WriteLine($"A {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite qualquer tecla para voltar ao Menu Principal...");
        Console.ReadKey();
        Console.Clear();
        Exibir_OP_Menu();
    }


}

void CalculaMediaBanda()
{
    Console.Clear();
    ExibirTituloOP("\nRealize o calculo da média de notas da Banda");
    Console.Write("\nDigite o nome da banda que deseja exibir a média:  ");
    string nomeDaBanda = Console.ReadLine()!;

    if (registroDeBandas.ContainsKey(nomeDaBanda))
    {

        
        foreach (var item in registroDeBandas.Values)
        {
            List<int> notasDaBanda = registroDeBandas[nomeDaBanda];
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}...");
            Console.WriteLine("Digite qualquer tecla para voltar ao Menu Principal...");
            Console.ReadKey();
            Console.Clear();
            Exibir_OP_Menu();
        }

    }
    else
    {
        Console.WriteLine($"A {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite qualquer tecla para voltar ao Menu Principal...");
        Console.ReadKey();
        Console.Clear();
        Exibir_OP_Menu();
    }

}


Exibir_OP_Menu();