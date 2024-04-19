using System;

class PessoaFisica : Padrao
{
       // Metodo obrigatório

       public override void taxaEmprestimo(double valor){
              Console.WriteLine("Txa de empréstimo para Pessoa Fisica R$: " + (valor * 0.1));
       }
}