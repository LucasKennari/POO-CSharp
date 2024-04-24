using System;

class Gerente : Imposto
{
       // metodo

       public override void valeAlimentacao(double salario)
       {
               Console.WriteLine("Desconto gerente do vale alimentacao R$: " + (salario * 0.15));
       }
       
}