using System;

namespace conceitos
{
       class Program 
       {
              static void Main(string[] args)
              {
                     //instanciar um objeto
                     Pessoa obj = new Pessoa();
                     obj.nome = "Lucas";
                     obj.idade = 26;
                     obj.mensagem();
              }
       }
}