using Propriedades_metodos_contrutores.Models;
using System;
internal class Program
{
    private static void Main(string[] args)

    {
        Pessoa p1 = new Pessoa(nome: "Lucas", sobrenome: "Cezar"); ; 
     /*    p1.Nome = "lucas";
        p1.Sobrenome = "Cezar";
     */
        Pessoa p2 = new Pessoa();
        p2.Nome = "Paulo";
        p2.Sobrenome = "Beto";


        Curso cursoDeIngles = new Curso("Ingles");
        cursoDeIngles.Alunos = new List<Pessoa>();

        cursoDeIngles.AdicionarAluno(p1);
        cursoDeIngles.AdicionarAluno(p2);

        cursoDeIngles.ListarAlunos();

        /*
        Pessoa pessoa = new Pessoa();
        pessoa.Nome = "Lucas";
        pessoa.Sobrenome = "Cezar";
        pessoa.Idade = 26;
        pessoa.Apresentar();
        Console.WriteLine("oi");
        Console.ReadLine();
        */
    }
}