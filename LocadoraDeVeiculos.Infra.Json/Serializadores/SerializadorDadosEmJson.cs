using LocadoraDeVeiculos.Infra.Json.ModuloPrecos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Infra.Json.Serializadores
{
    public class SerializadorDadosEmJson
    {
        private const string arquivo = @"C:\temp\dados.json";

        public ContextoDadosPrecos CarregarDadosDoArquivo()
        {
            if (File.Exists(arquivo) == false)
                return new ContextoDadosPrecos();

            string json = File.ReadAllText(arquivo);

            return JsonSerializer.Deserialize<ContextoDadosPrecos>(json);
        }

        public void GravarDadosEmArquivo(ContextoDadosPrecos dados)
        {
            var config = new JsonSerializerOptions { WriteIndented = true };

            string json = JsonSerializer.Serialize(dados, config);

            File.WriteAllText(arquivo, json);
        }

    }
}
