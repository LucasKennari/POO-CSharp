using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstracao_encapsulamento.Models
{
    internal class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, sou o professor: {Nome}, tenho {Idade} anos. Meu salário é de R$ {Salario},00");
        }
    }
}
