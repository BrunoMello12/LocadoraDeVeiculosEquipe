using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomoveis;
using LocadoraDeVeiculos.WinFormsApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloAutomovel
{
    public partial class TelaAutomovelForm : Form
    {
        public TelaAutomovelForm(List<GrupoAutomoveis> grupoDeAutomoveis)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            CarregarGrupoDeAltomoveis(grupoDeAutomoveis);
            CarregarTipoCombustivel();
        }

        private void CarregarTipoCombustivel()
        {
            TipoCombustivelEnum[] tiposCombustiveis = Enum.GetValues<TipoCombustivelEnum>();

            ArrayList items = new ArrayList();

            foreach (Enum tipoCombustivel in tiposCombustiveis)
            {
                items.Add(tipoCombustivel);
            }

            cbTipoCombustivel.DataSource = items;
            //cbTipoCombustivel.DisplayMember = "Value";
            //cbTipoCombustivel.ValueMember = "Key";
        }

        private void CarregarGrupoDeAltomoveis(List<GrupoAutomoveis> grupoDeAutomoveis)
        {
            cbGrpAutomoveis.Items.Clear();

            foreach (var item in grupoDeAutomoveis)
            {
                cbGrpAutomoveis.Items.Add(item);
            }
        }
    }
}
