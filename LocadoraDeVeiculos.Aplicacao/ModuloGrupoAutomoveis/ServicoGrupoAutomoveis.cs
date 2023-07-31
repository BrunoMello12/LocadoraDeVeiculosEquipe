using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomoveis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Aplicacao.ModuloGrupoAutomoveis
{
    public class ServicoGrupoAutomoveis
    {
        private IRepositorioGrupoAutomoveis repositorioGrupoAutomoveis;
        private IValidadorGrupoAutomoveis validadorGrupoAutomoveis;

        public ServicoGrupoAutomoveis(IRepositorioGrupoAutomoveis repositorioGrupoAutomoveis, IValidadorGrupoAutomoveis validadorGrupoAutomoveis)
        {
            this.repositorioGrupoAutomoveis = repositorioGrupoAutomoveis;
            this.validadorGrupoAutomoveis = validadorGrupoAutomoveis;
        }

        public Result Inserir(GrupoAutomoveis grupoAutomoveis)
        {
            Log.Debug("Tentando inserir Grupo de Automoveis...{@d}", grupoAutomoveis);

            List<string> erros = ValidarGrupoAutomoveis(grupoAutomoveis);

            try
            {
                repositorioGrupoAutomoveis.Inserir(grupoAutomoveis);

                Log.Debug("Grupo de Automoveis {GrupoAutomoveisId} inserido com sucesso", grupoAutomoveis.Id);

                return Result.Ok(); 
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar inserir Grupo de Automoveis.";

                Log.Error(exc, msgErro + "{@d}", grupoAutomoveis);

                return Result.Fail(msgErro); 
            }
        }

        public Result Editar(GrupoAutomoveis grupoAutomoveis)
        {
            Log.Debug("Tentando editar Grupo de Automoveis...{@d}", grupoAutomoveis);

            List<string> erros = ValidarGrupoAutomoveis(grupoAutomoveis);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try
            {
                repositorioGrupoAutomoveis.Editar(grupoAutomoveis);

                Log.Debug("Grupo de Automoveis {grupoAutomoveisId} editado com sucesso", grupoAutomoveis.Id);

                return Result.Ok();
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar editar Grupo de Automoveis.";

                Log.Error(exc, msgErro + "{@d}", grupoAutomoveis);

                return Result.Fail(msgErro);
            }
        }

        public Result Excluir(GrupoAutomoveis grupoAutomoveis)
        {
            Log.Debug("Tentando excluir Grupo de Automoveis...{@d}", grupoAutomoveis);

            try
            {
                bool grupoAutomoveisExiste = repositorioGrupoAutomoveis.Existe(grupoAutomoveis);

                if (grupoAutomoveisExiste == false)
                {
                    Log.Warning("Grupo de Automoveis {grupoAutomoveisId} não encontrado para excluir", grupoAutomoveis.Id);

                    return Result.Fail("Grupo de Automoveis não encontrado");
                }

                repositorioGrupoAutomoveis.Excluir(grupoAutomoveis);

                Log.Debug("Grupo de Automoveis {grupoAutomoveisId} excluído com sucesso", grupoAutomoveis.Id);

                return Result.Ok();
            }
            catch (SqlException ex)
            {
                List<string> erros = new List<string>();

                string msgErro;

                if (ex.Message.Contains("FK_TBAutomovel_TBGrupoAutomoveis"))
                    msgErro = "Este Grupo de Automoveis está relacionado com um automovel e não pode ser excluído";
                else
                    msgErro = "Falha ao tentar excluir Grupo de Automoveis";

                erros.Add(msgErro);

                Log.Error(ex, msgErro + " {grupoAutomoveisId}", grupoAutomoveis.Id);

                return Result.Fail(erros);
            }
        }

        private List<string> ValidarGrupoAutomoveis(GrupoAutomoveis grupoAutomoveis)
        {
            var resultadoValidacao = validadorGrupoAutomoveis.Validate(grupoAutomoveis);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            if (NomeDuplicado(grupoAutomoveis))
                erros.Add($"Este nome '{grupoAutomoveis.Nome}' já está sendo utilizado");

            foreach(string erro in erros)
            {
                Log.Warning(erro);
            }

            return erros;
        }

        private bool NomeDuplicado(GrupoAutomoveis grupoAutomoveis)
        {
            GrupoAutomoveis grupoAutomoveisEncontrado = repositorioGrupoAutomoveis.SelecionarPorNome(grupoAutomoveis.Nome);

            if (grupoAutomoveisEncontrado != null &&
            grupoAutomoveisEncontrado.Id != grupoAutomoveis.Id &&
                grupoAutomoveisEncontrado.Nome == grupoAutomoveis.Nome)
            {
                return true;
            }

            return false;
        }
    }
}
