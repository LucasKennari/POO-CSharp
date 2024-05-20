using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeHospedagem.Models
{
    internal class Suite
    {
        public Suite(int idQuarto, string tipoSuite, int capacidade, decimal valorDiaria, bool disponivel)
        {
            IdQuarto = idQuarto;
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
            Disponivel = disponivel;
        }
        public int IdQuarto { get; set; }
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }

        public bool Disponivel { get; set; }
    }
}
