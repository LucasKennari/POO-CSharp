using SistemaDeHospedagem.infra;
using System.Runtime.Intrinsics.X86;

namespace SistemaDeHospedagem.Models
{
    internal class Reserva 

    {
        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            int qtdDeHospedes = hospedes.Count();
           

           
            Console.WriteLine(Suite);
            if (Suite.Capacidade >= qtdDeHospedes)
            {

                Hospedes = hospedes;

            }
            else
            {
                throw new ArgumentException("Mensagem: Quantidade de hospedes acima da capacidade da suite ");
            }
        }

        public void CadastrarReserva(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {

            if (Hospedes.Count == 0)
            {
                throw new ArgumentException("Mensagem: Sem nenhum hospede no momento. ");
            }
            return Hospedes.Count();

        }


    }
}
