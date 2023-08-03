using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using LocadoraDeVeiculos.Dominio.ModuloPrecos;
using LocadoraDeVeiculos.Infra.Json.ModuloPrecos;
using LocadoraDeVeiculos.WinFormsApp.Compartilhado;
using LocadoraDeVeiculos.WinFormsApp.ModuloParceiro;
using LocadoraDeVeiculos.WinFormsApp.ModuloPrecos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloAluguel
{

    public class ControladorAluguel : ControladorBase
    {
        private RepositorioPrecosJson repositorioPrecosJson;
        private TabelaAluguelControl TabelaAluguel;
        private IRepositorioAluguel repositorioAluguel;

        public ControladorAluguel(RepositorioPrecosJson repositorioPrecosJson, IRepositorioAluguel repositorioAluguel)
        {
            this.repositorioPrecosJson = repositorioPrecosJson;
            this.repositorioAluguel = repositorioAluguel;
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            throw new NotImplementedException();
        }

        public override ConfiguracaoToolBoxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolBoxAluguel();
        }

        public override UserControl ObtemListagem()
        {
            if (TabelaAluguel == null)
                TabelaAluguel = new TabelaAluguelControl();

            CarregarAlugueis();

            return TabelaAluguel;
        }

        private void CarregarAlugueis()
        {
            List<Aluguel> alugueis = repositorioAluguel.SelecionarTodos();

            TabelaAluguel.AtualizarRegistros(alugueis);

            mensagemRodape = string.Format("Visualizando {0} parceiro{1}", alugueis.Count, alugueis.Count == 1 ? "" : "s");

            TelaPrincipalForm.Instancia.AtualizarRodape(mensagemRodape);
        }

        public override void Precos()
        {
            Precos registroPreco = repositorioPrecosJson.ObterRegistros().FirstOrDefault();

            if (registroPreco == null)
            {
                registroPreco = new Precos(Guid.NewGuid(), 0, 0, 0, 0);
            }

            TelaPrecosForm tela = new TelaPrecosForm(registroPreco);
            tela.ShowDialog();

            repositorioPrecosJson.Salvar(registroPreco);
        }
    }
}
