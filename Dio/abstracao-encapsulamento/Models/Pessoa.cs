using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstracao_encapsulamento.Models
{
    internal class Pessoa
    {
     
        public string Nome { get; set; }
        public int  Idade { get; set; }


        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, eu tenho {Idade}");
        }
    }
}
