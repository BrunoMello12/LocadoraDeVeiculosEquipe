﻿using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Aplicacao.ModuloFuncionario
{
    public class ServicoFuncionario
    {
        private IRepositorioFuncionario repositorioFuncionario;
        private IValidadorFuncionario validadorFuncionario;

        public ServicoFuncionario(IRepositorioFuncionario repositorioFuncionario, IValidadorFuncionario validadorFuncionario)
        {
            this.repositorioFuncionario = repositorioFuncionario;
            this.validadorFuncionario = validadorFuncionario;
        }

        public Result Inserir(Funcionario funcionario)
        {
            Log.Debug("Tentando inserir funcionario...{@d}", funcionario);

            List<string> erros = ValidarFuncionario(funcionario);

            if (erros.Count() > 0)
                return Result.Fail(erros); //cenário 2

            try
            {
                repositorioFuncionario.Inserir(funcionario);

                Log.Debug("Funcionario {FuncionarioId} inserida com sucesso", funcionario.Id);

                return Result.Ok(); //cenário 1
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar inserir funcionario.";

                Log.Error(exc, msgErro + "{@d}", funcionario);

                return Result.Fail(msgErro); //cenário 3
            }
        }

        public Result Editar(Funcionario funcionario)
        {
            Log.Debug("Tentando editar funcionario...{@d}", funcionario);

            List<string> erros = ValidarFuncionario(funcionario);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try
            {
                repositorioFuncionario.Editar(funcionario);

                Log.Debug("Funcionario {FuncionarioId} editada com sucesso", funcionario.Id);

                return Result.Ok();
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar editar funcionario.";

                Log.Error(exc, msgErro + "{@d}", funcionario);

                return Result.Fail(msgErro);
            }
        }

        public Result Excluir(Funcionario funcionario)
        {
            Log.Debug("Tentando excluir funcionario...{@d}", funcionario);

            try
            {
                bool funcionarioExiste = repositorioFuncionario.Existe(funcionario);

                if (funcionarioExiste == false)
                {
                    Log.Warning("Funcionario {FuncionarioId} não encontrada para excluir", funcionario.Id);

                    return Result.Fail("Funcionario não encontrada");
                }

                repositorioFuncionario.Excluir(funcionario);

                Log.Debug("Funcionario {FuncionarioId} excluída com sucesso", funcionario.Id);

                return Result.Ok();
            }
            catch (SqlException ex)
            {
                List<string> erros = new List<string>();

                string msgErro;

                if (ex.Message.Contains("FK_TBAluguel_TBFuncionario"))
                    msgErro = "Este funcionario está relacionada com um aluguel e não pode ser excluído";
                else
                    msgErro = "Falha ao tentar excluir funcionario";

                erros.Add(msgErro);

                Log.Error(ex, msgErro + " {FuncionarioId}", funcionario.Id);

                return Result.Fail(erros);
            }
        }

        private List<string> ValidarFuncionario(Funcionario funcionario)
        {
            var resultadoValidacao = validadorFuncionario.Validate(funcionario);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            if (NomeDuplicado(funcionario))
                erros.Add($"Este nome '{funcionario.Nome}' já está sendo utilizado");

            foreach (string erro in erros)
            {
                Log.Warning(erro);
            }

            return erros;
        }

        private bool NomeDuplicado(Funcionario funcionario)
        {
            Funcionario funcionarioEncontrado = repositorioFuncionario.SelecionarPorNome(funcionario.Nome);

            if (funcionarioEncontrado != null &&
                funcionarioEncontrado.Id != funcionario.Id &&
                funcionarioEncontrado.Nome == funcionario.Nome)
            {
                return true;
            }

            return false;
        }
    }
}
