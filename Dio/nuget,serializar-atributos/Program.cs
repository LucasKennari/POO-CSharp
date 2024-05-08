using Newtonsoft.Json;
using nuget_serializar_atributos.Models;
using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        // ===== DESCERIALIZACAO DE UM OBJETO JSON ===== //
        string path = @"C:/Users/lucas/OneDrive/Desktop/poo csharp/Dio/nuget,serializar-atributos/Arquivos/vendas.json";

        string conteudoArquivo = File.ReadAllText(path);

        List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

        foreach (var item in listaVenda)
        {
            Console.WriteLine($"Id: {item.Id}, Produto: {item.Produto}, Preco: {item.Preco}, Data: {item.DataVenda}");
        }

       // ===== SERIALIZACAO DE UM OBJETO JSON ===== //
       /*
        DateTime dataAtual = DateTime.Now;
        List<Venda> listaVendas = new List<Venda>();

        Venda v1 = new Venda(1, "picole", 2.00M, dataAtual);
        Venda v2 = new Venda(2, "sacole", 3.00M, dataAtual);

        listaVendas.Add(v1);
        listaVendas.Add(v2);

        string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);


        string path = @"C:/Users/lucas/OneDrive/Desktop/poo csharp/Dio/nuget,serializar-atributos/Arquivos/vendas.json";

        File.WriteAllText(path, serializado);

        string readText =  File.ReadAllText(path);
        Console.WriteLine(readText); 

       */


    }
}