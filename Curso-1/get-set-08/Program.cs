using System;

namespace getset
{
        class Program
       {
              public static void Main(string[] args)
              {
                     Pessoa p = new Pessoa();
                     p.Nome = "Lucas";
                     Console.WriteLine(p.Nome);
              }
       }
}