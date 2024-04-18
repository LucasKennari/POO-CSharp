public class Pessoa
{
       // Atributo nome;

       private string nome;

       // Somente a classe PESSOA vai ter acesso ao atributo nome.
       // entao vai ter algum momento em que voce deseja ABSTRAIR, ou seja, tirar informacao do atributo.
       // ou enviar.

       //GET E SET
       //Todo metodo get e set é publico e por boas praticas tem o mesmo nome do atributo e com a primeira letra maiuscula.
       public string Nome
       {
              get{return nome;}
              set{nome = value;}
       }
}