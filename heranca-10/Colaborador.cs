using System;

class Colaborador : Pessoa
{
       //atributos

       private
        double salario;

        //constructor

        public Colaborador(string nome, int idade, double salario)
        {
              this.nome = nome;
              this.idade = idade;
              this.salario = salario;

              mensagemPessoa();
              mensagemColaborador();
        }

       //metodos
       private void mensagemColaborador()
       {
              Console.WriteLine("Salario: " + salario);
       }
}