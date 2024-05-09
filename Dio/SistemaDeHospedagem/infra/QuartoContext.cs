using Newtonsoft.Json;
using SistemaDeHospedagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeHospedagem.infra
{
    internal class QuartoContext 
    {
        private string _path = @"C:/Users/lucas/OneDrive/Desktop/poo csharp/Dio/SistemaDeHospedagem/infra/quartos.json";

        public List<Quarto> Contents { get; set; }

        public  List<Quarto> GetQuartoContext()
        {

            var file = File.ReadAllText(_path);
            List<Quarto> todosOsQuartos = JsonConvert.DeserializeObject<List<Quarto>>(file);

            return todosOsQuartos;
            
        }

        public void SetQuartoContext()
        {
            string conteudo = JsonConvert.SerializeObject(Contents);
            File.WriteAllText(_path, conteudo);
     
        }
    }
    
}
