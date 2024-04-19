using System;
  // classe abstrada é um padrao para os projetos.
abstract class Padrao
{
       // Metodo obrigatorio -> Publico ou protegido.
       public abstract void taxaEmprestimo(double valor);

       // metodo opcional
       public void calculoPoupanca(double valor, double taxa)
       {
              Console.WriteLine("Ganhos obtidos pela poupanca R$: " +(valor * taxa));
       }
}
     