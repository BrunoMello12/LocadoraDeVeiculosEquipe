using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Aplicacao.ModuloAutomovel
{
    public class ServicoAutomovel
    {
        private IRepositorioAutomovel repositorioAutomovel;
        private ValidadorAutomovel validadorAutomovel;

        public ServicoAutomovel(IRepositorioAutomovel repositorioAutmovel, ValidadorAutomovel validadorAutomovel)
        {
            this.repositorioAutomovel = repositorioAutmovel;
            this.validadorAutomovel = validadorAutomovel;
        }

        public Result Inserir(Automovel automovel)
        {
            Log.Debug("Tentando inserir automóvel...{@a}", automovel);

            List<string> erros = ValidarAutomovel(automovel);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try
            {
                repositorioAutomovel.Inserir(automovel);

                Log.Debug("Automóvel {AutomovelId} inserido com sucesso", automovel.Id);

                return Result.Ok();
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar inserir automóvel.";

                Log.Error(exc, msgErro + "{@a}", automovel);

                return Result.Fail(msgErro);
            }
        }

        public Result Editar(Automovel automovel)
        {
            Log.Debug("Tentando editar automóvel...{@a}", automovel);

            List<string> erros = ValidarAutomovel(automovel);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try
            {
                repositorioAutomovel.Editar(automovel);

                Log.Debug("Automóvel {AutomovelId} editado com sucesso", automovel.Id);

                return Result.Ok();
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar editar automóvel.";

                Log.Error(exc, msgErro + "{@a}", automovel);

                return Result.Fail(msgErro);
            }
        }

        public Result Excluir(Automovel automovel)
        {
            Log.Debug("Tentando excluir automóvel...{@a}", automovel);

            try
            {
                repositorioAutomovel.Excluir(automovel);

                Log.Debug("Automóvel {AutomovelId} editada com sucesso", automovel.Id);

                return Result.Ok();
            }
            catch (Exception ex)
            {
                List<string> erros = new List<string>();

                string msgErro = ObterMensagemErro(ex);

                erros.Add(msgErro);

                Log.Logger.Error(ex, msgErro + " {AutomovelId}", automovel.Id);

                return Result.Fail(erros);
            }
        }

        private List<string> ValidarAutomovel(Automovel automovel)
        {
            List<string> erros = validadorAutomovel.Validate(automovel)
                .Errors.Select(x => x.ErrorMessage).ToList();

            //if (NomeDuplicado(automovel))
            //    erros.Add($"Este nome '{automovel.Nome}' já está sendo utilizado");

            foreach (string erro in erros)
            {
                Log.Warning(erro);
            }

            return erros;
        }

        private static string ObterMensagemErro(Exception ex)
        {
            string msgErro;

            if (ex.Message.Contains("FK_TBAluguel_TBAutomovel"))
                msgErro = "Este automóvel está relacionado com um aluguel e não pode ser excluído";
            else
                msgErro = "Este automóvel não pode ser excluído";

            return msgErro;
        }
    }
}
