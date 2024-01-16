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

            Console.WriteLine("Digite a placa do veiculo");
            string placa = Console.ReadLine();

            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            Console.WriteLine("Digite a placa do seu veículo");
            string placa = Console.ReadLine();


            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {



                int horas = 0;
                decimal valorTotal = 0;
                Console.ReadLine();
                Console.WriteLine($"{precoInicial} + {precoPorHora} * {horas} = {valorTotal}");


                veiculos.Remove($"{placa}");

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {

            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                int contadorForeach = 0;
                foreach (string placa in veiculos)
                {
                    Console.WriteLine($" Esses {contadorForeach} - {placa}");
                    contadorForeach++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
