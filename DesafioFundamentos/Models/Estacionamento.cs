namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                string placa = Console.ReadLine();

                // Verifica se a placa já está cadastrada
                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    Console.WriteLine("Este veículo já está estacionado aqui.");
                }
                else
                {
                    veiculos.Add(placa);
                    Console.WriteLine($"Veículo {placa} estacionado com sucesso!");
                }

                Console.WriteLine("Deseja adicionar outro veículo? (s/n)");
                string resposta = Console.ReadLine().ToLower();

                if (resposta != "s")
                {
                    continuar = false;
                }
            }
        }

        public void RemoverVeiculo()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Digite a placa do veículo para remover:");
                string placa = Console.ReadLine();

                // Verifica se o veículo existe
                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    int horas = Convert.ToInt32(Console.ReadLine());

                    // Calcula o valor total
                    decimal valorTotal = precoInicial + (precoPorHora * horas);

                    // Remove a placa da lista
                    veiculos.Remove(placa);

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
                }

                Console.WriteLine("Deseja remover outro veículo? (s/n)");
                string resposta = Console.ReadLine().ToLower();

                if (resposta != "s")
                {
                    continuar = false;
                }
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string veiculo in veiculos)
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
}