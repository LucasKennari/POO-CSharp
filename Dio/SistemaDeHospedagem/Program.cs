using SistemaDeHospedagem.Models;
using Newtonsoft.Json;
try
{

    Quarto quartos = new Quarto();
    //quartos.ListarTodosOsQuartos();
    Console.WriteLine("\n");
    // Console.WriteLine("Reservados\n");
    // quartos.QuartosReservados();
    Console.WriteLine("\n");
    Console.WriteLine("Disponiveis\n");
    quartos.QuartosDisponiveis();

    List<Pessoa> hospedes = new List<Pessoa>();

    Reserva reserva = new Reserva();

    Pessoa pessoa1 = new Pessoa("Lucas", "Cezar");
    Pessoa pessoa2 = new Pessoa("Roberto", "Cezar");

    hospedes.Add(pessoa1);
    hospedes.Add(pessoa2);

    Suite suite = new Suite(tipoSuite: "Premium", capacidade: 4, valorDiaria: 150);


    reserva.CadastrarSuite(suite);
    reserva.CadastrarHospedes(hospedes);
}
catch (Exception error)
{
    Console.WriteLine(error.Message);

}




