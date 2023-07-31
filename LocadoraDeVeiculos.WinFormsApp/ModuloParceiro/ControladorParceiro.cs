using LocadoraDeVeiculos.Aplicacao.ModuloParceiro;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using LocadoraDeVeiculos.WinFormsApp.ModuloParceiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloParceiro
{
    public class ControladorParceiro
    {
        private IRepositorioParceiro repositorioParceiro;

        private TabelaParceiroControl tabelaParceiro;

        private ServicoParceiro servicoParceiro;

        public ControladorParceiro(IRepositorioParceiro repositorioParceiro, TabelaParceiroControl tabelaParceiro, ServicoParceiro servicoParceiro)
        {
            this.repositorioParceiro = repositorioParceiro;
            this.tabelaParceiro = tabelaParceiro;
            this.servicoParceiro = servicoParceiro;
        }
    }
}
