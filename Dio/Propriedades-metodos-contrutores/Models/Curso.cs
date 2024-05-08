using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades_metodos_contrutores.Models
{
    public class Curso 
    {
        public string Nome { get; set; }

        public List<Pessoa> Alunos { get; set; }

        public Curso(string nome)
        {
            Nome = nome;
        }

        public void AdicionarAluno(Pessoa aluno) 
        {
            Alunos.Add(aluno);
        }

        public bool RemoverAluno(Pessoa aluno) 
        {
          

            return Alunos.Remove(aluno); 
          
        }

        public void ListarAlunos()
        {
            for (int count = 0; count < Alunos.Count; count++)
            {
                Console.WriteLine(Alunos[count].NomeCompleto);

            }
        }

        public int ObterQtdDeAlunosMatriculados() 

        {
        
            return Alunos.Count;
        }
    }
}
