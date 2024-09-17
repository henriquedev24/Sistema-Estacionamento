using System;

namespace EstacionamentoNET.Models;

    public class EstacionamentoValores(decimal precoInicial, decimal precoPorHora)
{
    private decimal precoInicial = precoInicial;
    private decimal precoPorHora = precoPorHora;


    private List<string> veiculos = new List<string>();

    public void AdicionarVeiculo()
    {
        // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
        // *IMPLEMENTE AQUI*
        Console.WriteLine("Digite a placa do veículo para estacionar:");
        Console.ReadLine();
        veiculos.Add("");
        if (veiculos.Count > 0)
        {
            Console.WriteLine("Veículo Cadastrado");
        }
        
    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para remover:");

        Console.ReadLine();
        string placa = "";

        // Verifica se o veículo existe
        if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
        {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

            int horas = 0;
            decimal valorTotal = precoInicial + precoPorHora * horas;

            veiculos.Remove(placa);

            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
        }
        else
        {
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
        }
    }

    public void ListarVeiculos()
    {
        // Verifica se há veículos no estacionamento
        if (veiculos.Count != 0)
        {
            Console.WriteLine("Os veículos estacionados são:");
            foreach (var veiculo in veiculos)
            {
                Console.WriteLine(veiculo);
            }
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
    }
}
