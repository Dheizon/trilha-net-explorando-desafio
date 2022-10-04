using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Seja bem vindo ao sistema de HOSPEDAGEM!");

bool exibirMenu = true;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar hospedes");
    Console.WriteLine("2 - Efetuar reserva");
    Console.WriteLine("3 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Informe o nome do hospede:");
            string nome = Console.ReadLine();
            if (nome == null)
            {
                Console.WriteLine("Nome invalido");
                break;
            }
            else
            {
                Pessoa pessoa = new Pessoa(nome: nome);
                hospedes.Add(pessoa);
            }
            break;

        case "2":
            Console.WriteLine("Digite a suite para hospedagem:");
            Console.WriteLine("1 - Menos Premium");
            Console.WriteLine("2 - Quase Premuim");
            Console.WriteLine("3 - Premium");

            string tipoSuite = Console.ReadLine();
            int intTipoSuite = 0;
            bool validaOpcaoSuite = int.TryParse(tipoSuite, out intTipoSuite);

            if (validaOpcaoSuite)
            {
                // Cria a suíte
                Suite suite = new Suite(intTipoSuite);

                // Cria uma nova reserva, passando a suíte e os hóspedes
                Console.WriteLine("Informe a quantidade de dias:");
                string qtdeDias = Console.ReadLine();

                Reserva reserva = new Reserva(diasReservados: Convert.ToInt32(qtdeDias));
                reserva.CadastrarSuite(suite);

                if (hospedes.Count > 0)
                    reserva.CadastrarHospedes(hospedes);

                // Exibe a quantidade de hóspedes e o valor da diária
                Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
                Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria().ToString("C2")}");
            }
            else
            {
                Console.WriteLine("Opcao de suite invalida");
            }

            break;

        case "3":
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");