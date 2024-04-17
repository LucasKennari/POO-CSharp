using System;

namespace conceitos
{
       class Program 
       {
              static void Main(string[] args)
              {
                     Pessoa p1 = new Pessoa();
                     
                     p1.peso = 50;
                     p1.altura = 1.70;

                     p1.exibir_msg(); 
              }
       }
}