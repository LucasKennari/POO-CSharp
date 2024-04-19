using System;

class Imposto
{

       // Metodos

       public virtual void valeAlimentacao(double salario)
       {
              Console.WriteLine("Desconto padrão do vale alimentacao R$: " + (salario * 0.1));
       }
       public void valeTransporte(double salario)
       {
              Console.WriteLine("Desconto padrão do vale Transporte R$: " + (salario * 0.06));
       }
}