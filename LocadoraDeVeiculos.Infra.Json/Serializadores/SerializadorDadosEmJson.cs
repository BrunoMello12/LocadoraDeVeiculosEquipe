﻿using LocadoraDeVeiculos.Infra.Json.ModuloPrecos;
using System.Text.Json;

namespace LocadoraDeVeiculos.Infra.Json.Serializadores
{
    public class SerializadorDadosEmJson
    {
        private const string arquivo = @"E:\Arquivos\LocadoraWithGuys\Precos.json";

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
