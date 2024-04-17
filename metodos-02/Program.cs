using System;

namespace metodos
{
       class Program 
       {
              static void Main(string[] args)
              {

                     Pessoa obj = new Pessoa();
                     obj.apresentar();
                     obj.apresentar("lucas");
                     obj.apresentar("jose", 256);
              }
       }
}