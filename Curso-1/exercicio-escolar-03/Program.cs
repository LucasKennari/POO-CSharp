using System;

namespace exercicio_escolar
{
       class Program 
       {
              static void Main(string[] args)
              {
                     Aluno a = new Aluno();
                     a.nome = "Lucas";
                     a.nota1 = 3;
                     a.nota2 = 4;

                     a.mensagem();
              }
       }
}