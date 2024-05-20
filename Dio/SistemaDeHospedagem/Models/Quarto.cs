using Newtonsoft.Json;
using SistemaDeHospedagem.infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeHospedagem.Models
{
    internal class Quarto
    {

        public Quarto()
        {

        }
       
        [JsonProperty("idQuarto")]
        public int IdDoQuarto { get; set; }

        public bool Disponivel { get; set; }

        public void ListarTodosOsQuartos()
        {
             QuartoContext quartos = new QuartoContext();
            var todosOsQuartos = quartos.GetQuartoContext();

            foreach (var item in todosOsQuartos)
            {
                string ocupacao = "";
                Console.WriteLine($"Numero do quarto: {item.IdDoQuarto}");
                if (item.Disponivel == true)
                {
                    ocupacao = "Disponivel";
                }
                else
                {
                    ocupacao = "Reservado";
                }

                Console.WriteLine($"Ocupacao : {ocupacao}");
            }


        }
        public void QuartosReservados()
        {
            QuartoContext quartos = new QuartoContext();
           var todosOsQuartos =  quartos.GetQuartoContext();
            foreach (var item in todosOsQuartos)
            {
                if (item.Disponivel == false)
                {
                    Console.WriteLine($"Numero do quarto: {item.IdDoQuarto}");
                    Console.WriteLine($"Ocupacao : Reservado");
                }
            }
        }
        public void QuartosDisponiveis()
        {
            QuartoContext quartos = new QuartoContext();
            var todosOsQuartos = quartos.GetQuartoContext();
            foreach (var item in todosOsQuartos)
            {
                if (item.Disponivel == true)
                {
                    Console.WriteLine($"Numero do quarto: {item.IdDoQuarto}");
                    Console.WriteLine($"Ocupacao : Disponivel");
                }
            }
        }

    
    }

}

s