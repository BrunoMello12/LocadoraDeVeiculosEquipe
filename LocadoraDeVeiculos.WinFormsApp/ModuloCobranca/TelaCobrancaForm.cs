using FluentResults;
using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloCobranca;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomoveis;
using LocadoraDeVeiculos.WinFormsApp.Compartilhado;
using System.Collections;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloCobranca
{
    public partial class TelaCobrancaForm : Form
    {
        private Cobranca cobranca;
        public event GravarRegistroDelegate<Cobranca> onGravarRegistro;

        public TelaCobrancaForm(List<GrupoAutomoveis> grupoAutomoveis)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            CarregarGrupoAutomoveis(grupoAutomoveis);
            CarregarEnum();
        }

        public Cobranca ObterCobranca()
        {
            cobranca.GrupoAutomoveis = (GrupoAutomoveis)cbGrupoAutomoveis.SelectedItem;
            cobranca.TipoPlano = (TipoPlanoEnum)cbTipoPlano.SelectedItem;
            cobranca.PrecoDiaria = Convert.ToDecimal(txtPrecoDiaria.Text);

            if (cobranca.TipoPlano == TipoPlanoEnum.PlanoDiario)
                cobranca.PrecoPorKm = Convert.ToDecimal(txtPrecoExtrapolado.Text);
            else if (cobranca.TipoPlano == TipoPlanoEnum.PlanoControlador)
            {
                cobranca.PrecoPorKm = Convert.ToDecimal(txtPrecoExtrapolado.Text);
                cobranca.KmDisponivel = Convert.ToDecimal(txtKmDisponivel.Text);
            }

            return cobranca;
        }

        public void ConfigurarCobranca(Cobranca cobranca)
        {
            cbGrupoAutomoveis.SelectedItem = cobranca.GrupoAutomoveis;
            cbTipoPlano.SelectedItem = cobranca.TipoPlano;
            txtPrecoDiaria.Text = cobranca.PrecoDiaria.ToString();
            txtPrecoExtrapolado.Text = cobranca.PrecoPorKm.ToString();
            txtKmDisponivel.Text = cobranca.KmDisponivel.ToString();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.cobranca = ObterCobranca();

            Result resultado = onGravarRegistro(cobranca);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void cbTipoPlano_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cobranca.TipoPlano == TipoPlanoEnum.PlanoLivre)
            {
                txtKmDisponivel.Enabled = false;
                txtPrecoExtrapolado.Enabled = false;
            }
            else if (cobranca.TipoPlano == TipoPlanoEnum.PlanoDiario)
            {
                txtKmDisponivel.Enabled = false;
                txtPrecoExtrapolado.Enabled = true;
            }
            else if (cobranca.TipoPlano == TipoPlanoEnum.PlanoControlador)
            {
                txtKmDisponivel.Enabled = true;
                txtPrecoExtrapolado.Enabled = true;
            }
        }

        private void CarregarEnum()
        {
            TipoPlanoEnum[] tipos = Enum.GetValues<TipoPlanoEnum>();

            ArrayList items = new ArrayList();

            foreach (Enum tipo in tipos)
            {
                var item = KeyValuePair.Create(tipo, tipo.GetDescription());
                items.Add(item);
            }

            cbTipoPlano.DataSource = items;
            cbTipoPlano.DisplayMember = "Value";
            cbTipoPlano.ValueMember = "Key";
        }

        private void CarregarGrupoAutomoveis(List<GrupoAutomoveis> grupoAutomoveis)
        {
            foreach (GrupoAutomoveis gp in grupoAutomoveis)
            {
                cbGrupoAutomoveis.Items.Add(gp);
            }
        }
    }
}
