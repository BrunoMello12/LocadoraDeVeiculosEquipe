using LocadoraDeVeiculos.Aplicacao.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloFuncionario
{
    public class ControladorFuncionario
    {
        private IRepositorioFuncionario repositorioFuncionario;

        private TabelaFuncionarioControl tabelaFuncionario;

        private ServicoFuncionario servicoFuncionario;

        public ControladorFuncionario(IRepositorioFuncionario repositorioFuncionario, TabelaFuncionarioControl tabelaFuncionario, ServicoFuncionario servicoFuncionario)
        {
            this.repositorioFuncionario = repositorioFuncionario;
            this.tabelaFuncionario = tabelaFuncionario;
            this.servicoFuncionario = servicoFuncionario;
        }

    }
}
