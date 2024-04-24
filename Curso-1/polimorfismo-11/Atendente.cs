using System;

class Atendente : Imposto
{
       public override void valeAlimentacao(double salario)
       {
               Console.WriteLine("Desconto atendente do vale alimentacao R$: " + (salario * 0.12));
       }
}