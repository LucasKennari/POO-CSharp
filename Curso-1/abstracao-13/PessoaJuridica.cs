using System;

class PessoaJuridica : Padrao
{
       // Metodo obrigatório

       public override void taxaEmprestimo(double valor){
              Console.WriteLine("Txa de empréstimo para Pessoa Juridica R$: " + (valor * 0.20));
       }
}