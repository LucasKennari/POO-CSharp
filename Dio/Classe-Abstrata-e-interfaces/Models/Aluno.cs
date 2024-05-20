using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Abstrata_e_interfaces.Models
{
    internal class Aluno : Pessoa
    {
        public Aluno(string nome) : base(nome)
        {
             
        }
        public double Nota { get; set; }
        public override void Apresentar()
        {

        }
    }
}
