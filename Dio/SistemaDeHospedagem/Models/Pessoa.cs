using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeHospedagem.Models
{
    internal class Pessoa : Reserva
    {

        public 
            
            Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;

        }

        private string _nome;
        private string _sobrenome;

        private string Nome
        {
            get { return _nome; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Nome inválido");
                }else
                {
                    _nome = value;
                }
            }
        }
       

        public string Sobrenome {
            get { return _sobrenome; } 
            set => _sobrenome = value; }



    }
}
