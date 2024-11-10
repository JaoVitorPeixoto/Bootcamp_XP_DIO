using SintaxeC_.Mains;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("-------------------- BEM VINDO AOS MEUS ESTUDOS DE C# --------------------");
while (true)
{
    
    Console.WriteLine("0 - Sair do programa");
    Console.WriteLine("1 - Calculadora");
    Console.WriteLine("2 - Tabuada");
    Console.WriteLine("3 - Arrays");
    Console.WriteLine("4 - Formatação");
    Console.WriteLine("Escolha uma opção: ");
    if (!int.TryParse(Console.ReadLine(), out int opcao))
        opcao = -1;

    Console.Clear();

    switch (opcao)
    {
        case 0:
            Console.WriteLine("PROGRAMA FINALIZADO...");
            Environment.Exit(0);
            break;

        case 1:
            Calculadora.Main();
            break;

        case 2:
            Tabuada.Main();
            break;

        case 3:
            SintaxeC_.Mains.Array.Main();
            break;
        
        case 4:
            Formatacao.Main();
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    
    Console.WriteLine("------------------------------------------------------------------");
    Console.WriteLine("Pressione uma tecla para continuar...");
    Console.ReadLine();
    Console.Clear();
}

