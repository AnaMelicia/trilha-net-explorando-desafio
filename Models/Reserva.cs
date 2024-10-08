namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            //IMPLEMENTADO!
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // IMPLEMENTADO!!

                throw new ArgumentException("Número de hóspedes excede a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // IMPLEMENTADO!!
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // IMPLEMENTADO!!
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // IMPLEMENTADO!!
            if (DiasReservados >= 10)
            {
                valor *= 0.90m;
            }

            return valor;
        }
    }
}