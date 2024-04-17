using System; 

class Aluno
{
       // Atributos

       // nome
       public string nome;
       // notas
       public double nota1, nota2;

       // Media
       public double media()
       {
              return (nota1 + nota2) / 2;
       }
       // Situacao
       public string situacao(double media) 
       {
              return media >= 7 ? "Aprovado" : "Reprovado";
       }
       // Mnsagem + nome + media + situacao
       public void mensagem()
       {
              // obter media
              double obter_media = media();
              // obter situacao 
              string obter_situacao = situacao(obter_media);
              // mensgem
              Console.WriteLine("O aluno "+nome+", está "+obter_situacao+". Sua media foi: "+obter_media+"");

       }

}