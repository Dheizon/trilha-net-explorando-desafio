namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite() { }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        public Suite(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    TipoSuite = "Menos premium";
                    Capacidade = 2;
                    ValorDiaria = 30;
                    break;
                case 2:
                    TipoSuite = "Quase Premium";
                    Capacidade = 4;
                    ValorDiaria = 60;
                    break;
                case 3:
                    TipoSuite = "Premium";
                    Capacidade = 6;
                    ValorDiaria = 100;
                    break;
                default:
                    break;
            }
        }

        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}