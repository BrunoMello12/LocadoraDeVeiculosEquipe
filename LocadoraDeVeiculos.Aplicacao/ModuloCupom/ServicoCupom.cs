using LocadoraDeVeiculos.Dominio.ModuloCupom;

namespace LocadoraDeVeiculos.Aplicacao.ModuloCupom
{
    public class ServicoCupom
    {
        private IRepositorioCupom repositorioCupom;
        private IValidadorCupom validadorCupom;

        public ServicoCupom(IRepositorioCupom repositorioCupom, IValidadorCupom validadorCupom)
        {
            this.repositorioCupom = repositorioCupom;
            this.validadorCupom = validadorCupom;
        }

        public Result Inserir(Cupom cupom)
        {
            Log.Debug("Tentando inserir Cupom...{@d}", cupom);

            List<string> erros = ValidarCupom(cupom);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try
            {
                repositorioCupom.Inserir(cupom);

                Log.Debug("Cupom {cupomId} inserido com sucesso", cupom.Id);

                return Result.Ok();
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar inserir cupom.";

                Log.Error(exc, msgErro + "{@d}", cupom);

                return Result.Fail(msgErro);
            }
        }

        public Result Editar(Cupom cupom)
        {
            Log.Debug("Tentando editar Cupom...{@d}", cupom);

            List<string> erros = ValidarCupom(cupom);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try
            {
                repositorioCupom.Editar(cupom);

                Log.Debug("Cupom {cupomId} editado com sucesso", cupom.Id);

                return Result.Ok();
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar editar Cupom.";

                Log.Error(exc, msgErro + "{@d}", cupom);

                return Result.Fail(msgErro);
            }
        }

        public Result Excluir(Cupom cupom)
        {
            Log.Debug("Tentando excluir Cupom...{@d}", cupom);

            //try
            //{
                bool cupomExiste = repositorioCupom.Existe(cupom);

                if (cupomExiste == false)
                {
                    Log.Warning("Cupom {cupomId} editado com sucesso", cupom.Id);

                    return Result.Fail("Cupom não encontrado");
                }

                repositorioCupom.Excluir(cupom);

                Log.Debug("Cupom {cupomId} excluído com sucesso", cupom.Id);

                return Result.Ok();
            //}
            //catch (SqlException ex)
            //{
            //    List<string> erros = new List<string>();

            //    string msgErro;

            //    if (ex.Message.Contains("FK_TBCupom_TBCobranca"))
            //        msgErro = "Este plano de cobrança está relacionado com um aluguel e não pode ser excluído";
            //    else
            //        msgErro = "Falha ao tentar excluir plano de cobrança";

            //    erros.Add(msgErro);

            //    Log.Error(ex, msgErro + " {cobrancaId}", cupom.Id);

            //    return Result.Fail(erros);
            //}
        }

        private List<string> ValidarCupom(Cupom cupom)
        {
            var resultadoValidacao = validadorCupom.Validate(cupom);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            foreach (string erro in erros)
            {
                Log.Warning(erro);
            }

            return erros;
        }
    }
}
