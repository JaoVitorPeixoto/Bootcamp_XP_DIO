using SintaxeC_.Mains;

Console.WriteLine("-------------------- BEM VINDO AOS MEUS ESTUDOS DE C# --------------------");
while (true)
{
    
    Console.WriteLine("ESCOLHA NOVAMENTE!");
    Console.WriteLine("0 - Sair do progr");
    Console.WriteLine("1 - Calculadora");
    Console.WriteLine("2 - Tabuada");
    Console.WriteLine("Escolha uma opção: ");
    int opcao = int.Parse(Console.ReadLine());

    Console.WriteLine("------------------------------------------------------------------");

    switch (opcao)
    {
        case 0:
            Console.WriteLine("PROGRAMA FINALIZADO...");
            return;

        case 1:
            Calculadora.Main();
            break;

        case 2:
            Tabuada.Main();
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    
    Console.WriteLine("------------------------------------------------------------------");
}

