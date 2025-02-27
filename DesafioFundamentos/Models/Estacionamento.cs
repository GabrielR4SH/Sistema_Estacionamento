namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial,decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            System.Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            if(veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                System.Console.WriteLine("Este veículo já está estacionado aqui");
            } 
            else
            {
                veiculos.Add(placa);
                System.Console.WriteLine($"Veículo {placa} estacionado com sucesso!");
            }
        }
    }
}