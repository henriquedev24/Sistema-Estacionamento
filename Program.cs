using System;
using EstacionamentoNET.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Bem-vindo ao sistema de estacionamento\n" + "Digite o preço inicial:");

try
{
    precoInicial = Convert.ToDecimal(Console.ReadLine()); 
}
catch (FormatException)
{
    Console.WriteLine("Valor inválido! Use um número válido.");
    return;
}

Console.WriteLine("Agora digite o preço por hora:");
try
{
    precoPorHora = Convert.ToDecimal(Console.ReadLine()); 
}
catch (FormatException)
{
    Console.WriteLine("Valor inválido! Use um número válido.");
    return;
}

EstacionamentoValores es = new EstacionamentoValores(precoInicial, precoPorHora);


string opcao = string.Empty;
bool menuExibicao = true;

while (menuExibicao)
{
    Console.Clear();
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículo");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            menuExibicao = false;
            break;

        default:
            Console.WriteLine("Inválido");
            break;
    }

    Console.WriteLine("Tecle qualquer tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("Encerrado o programa");