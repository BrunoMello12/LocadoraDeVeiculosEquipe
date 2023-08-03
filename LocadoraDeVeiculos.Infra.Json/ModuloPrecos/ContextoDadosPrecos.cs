using System.Text.Json.Serialization;
using System.Text.Json;
using LocadoraDeVeiculos.Dominio.ModuloPrecos;

namespace LocadoraDeVeiculos.Infra.Json.ModuloPrecos
{
    public class ContextoDadosPrecos
    {
        private const string NOME_ARQUIVO = "Precos\\LocadoraDeVeiculos.json";

        public Precos preco;

        public ContextoDadosPrecos()
        {
            preco = new Precos();
        }

        public ContextoDadosPrecos(bool carregarDados) : this()
        {
            if (carregarDados)
                CarregarDoArquivoJson();
        }

        public void GravarEmArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            string registrosJson = JsonSerializer.Serialize(this, config);

            File.WriteAllText(NOME_ARQUIVO, registrosJson);
        }

        private void CarregarDoArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            if (File.Exists(NOME_ARQUIVO))
            {
                string registrosJson = File.ReadAllText(NOME_ARQUIVO);

                if (registrosJson.Length > 0)
                {
                    ContextoDadosPrecos ctx = JsonSerializer.Deserialize<ContextoDadosPrecos>(registrosJson, config);

                    this.preco = ctx.preco;
                }
            }
        }

        private static JsonSerializerOptions ObterConfiguracoes()
        {
            JsonSerializerOptions opcoes = new JsonSerializerOptions();
            opcoes.IncludeFields = true;
            opcoes.WriteIndented = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;

            return opcoes;
        }
    }
}
