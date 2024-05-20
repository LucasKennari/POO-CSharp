using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Abstrata_e_interfaces.Models
{
    internal class Pessoa
    {
        public Pessoa(string nome)
        {
            Nome = nome
        }
        public string Nome { get; set; }
        public int Int { get; set; }
        public string Email { get; set; }

        public virtual void Apresentar() { }
    }
}
