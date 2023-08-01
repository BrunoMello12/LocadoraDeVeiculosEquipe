using LocadoraDeVeiculos.Aplicacao.ModuloParceiro;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using LocadoraDeVeiculos.WinFormsApp.Compartilhado;
using LocadoraDeVeiculos.WinFormsApp.ModuloParceiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloParceiro
{
    public class ControladorParceiro : ControladorBase
    {
        private IRepositorioParceiro repositorioParceiro;

        private TabelaParceiroControl tabelaParceiro;

        private ServicoParceiro servicoParceiro;

        public ControladorParceiro(IRepositorioParceiro repositorioParceiro, ServicoParceiro servicoParceiro)
        {
            this.repositorioParceiro = repositorioParceiro;
            this.servicoParceiro = servicoParceiro;
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
            throw new NotImplementedException();
        }

        public override UserControl ObtemListagem()
        {
            throw new NotImplementedException();
        }
    }
}
