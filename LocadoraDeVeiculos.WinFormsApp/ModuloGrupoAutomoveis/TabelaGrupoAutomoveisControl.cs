using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomoveis;
using LocadoraDeVeiculos.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloGrupoAutomoveis
{
    public partial class TabelaGrupoAutomoveisControl : UserControl
    {
        public TabelaGrupoAutomoveisControl()
        {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
        }

        public int ObtemIdSelecionado()
        {
            return grid.SelecionarId();
        }

        public void AtualizarRegistros(List<GrupoAutomoveis> grupoAutomoveis)
        {
            grid.Rows.Clear();

            foreach (GrupoAutomoveis gpAutomoveis in grupoAutomoveis)
            {
                grid.Rows.Add(gpAutomoveis.Id, gpAutomoveis.Nome);
            }
        }
    }
}
