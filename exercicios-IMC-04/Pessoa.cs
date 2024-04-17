using System;

class Pessoa
{
       // ATRIBUTOS
       // nome da pessoa
     
       // peso
       public double peso,altura;
      
       // METODOS

       //calcular IMC
       public double imc() // sem parametros
       {
              return peso / (altura * altura);
       }
       // retornar resultado
       public string situacao(double imc) // necessario informar a tipagem
       {
              string retorno;
              if (imc < 18.5)
              {
                     retorno = "Abaixo do peso";
              }
              else if (imc >= 18.5 && imc < 25)
              {
                     retorno = "Peso normal";
              }
              else if (imc >= 25 && imc < 30)
              {
                     retorno = "Acima do peso";
              }
              else if (imc >= 30 && imc < 35)
              {
                     retorno = "Obesidade 1";
              }
              else if (imc >= 35 && imc < 40)
              {
                     retorno = "Obesidade 2";
              } else
              {
                     retorno = "Obesidade 3";
              }
              return retorno;
       }
       public void exibir_msg()
       {
              // Calcular o imc
              double resultado_imc = imc();

              string resultado_situacao = situacao(resultado_imc);

              // obter situacao
              Console.WriteLine("Seu IMC: " + resultado_imc);
              Console.WriteLine("Sua situacao: " + resultado_situacao);
       }     


}