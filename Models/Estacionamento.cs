
namespace EstacionamentoNET.Models;

public class EstacionamentoValores(decimal precoInicial, decimal precoPorHora
)
{
    private decimal precoInicial;
    private decimal precoPorHora;


    private List<string> veiculos = new List<string>();


    public void AdicionarVeiculo()
    {

        Console.WriteLine("Digite a placa do veículo para estacionar:");
        string placa = Console.ReadLine();
        
        if (!string.IsNullOrWhiteSpace(placa))
        {
            veiculos.Add(placa);
            Console.WriteLine("Veículo Cadastrado");
        }
        else 
        {
            Console.WriteLine("Placa inválida");
        }

    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para remover:");

        
        string placa = Console.ReadLine();

        // Verifica se o veículo existe
        if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
        {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

            int horas;
             while (!int.TryParse(Console.ReadLine(), out horas) || horas < 0)
            {
                Console.WriteLine("Valor inválido. Digite um número de horas válido.");
            }

            decimal valorTotal = precoInicial + (precoPorHora * horas);

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
