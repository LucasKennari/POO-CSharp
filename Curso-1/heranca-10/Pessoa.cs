using System;

class Pessoa
{
       // protected -> apenas a classe que é criado aquele atributo ou metodo, alem de classes que extendem, ou seja, herdar.
       protected string nome;
       protected int idade;

       protected void mensagemPessoa()
       {
              Console.WriteLine("Nome: " + nome);
              Console.WriteLine("Idade: " + idade);
       }
}