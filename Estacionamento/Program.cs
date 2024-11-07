// See https://aka.ms/new-console-template for more information
using Estacionamento.models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("-------------------- BEM VINDO AO ESTACIONAMENTO --------------------");

Console.WriteLine("Digite o preço inicial:");
var precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
var precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento.models.Estacionamento estacionamento = new Estacionamento.models.Estacionamento(precoInicial, precoPorHora);

Console.Clear();
while (true)
{
    Console.WriteLine("0 - Sair do programa");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("Escolha uma opção: ");
    if (!int.TryParse(Console.ReadLine(), out int opcao))
        opcao = -1;

    Console.Clear();

    switch (opcao)
    {
        case 0:
            Console.WriteLine("Programa finalizado...");
            Environment.Exit(0);
            break;

        case 1:
            estacionamento.CadastrarVeiculo();
            break;

        case 2:
            estacionamento.RemoverVeiculo();
            break;

        case 3:
            estacionamento.ListaVeiculos();
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;

       
    }

    Console.WriteLine("------------------------------------------------------------------");
    Console.WriteLine("Pressione uma tecla para continuar...");
    Console.ReadLine();
    Console.Clear();

}