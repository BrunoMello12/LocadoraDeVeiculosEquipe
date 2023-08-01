using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloCupom;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using LocadoraDeVeiculos.WinFormsApp.Compartilhado;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloCupom
{
    public partial class TelaCupomForm : Form
    {
        private Cupom cupom;
        public event GravarRegistroDelegate<Cupom> onGravarRegistro;

        public TelaCupomForm(List<Parceiro> parceiros)
        {
            InitializeComponent();
            CarregarParceiros(parceiros);
        }

        public Cupom ObterCupom()
        {
            cupom.Nome = txtNome.Text;
            cupom.Valor = Convert.ToInt32(txtValor.Text);
            cupom.DataValidade = dateValidade.Value;
            cupom.Parceiro = (Parceiro)cbParceiro.SelectedItem;

            return cupom;
        }

        public void ConfigurarCupom(Cupom cupom)
        {
            txtNome.Text = cupom.Nome;
            txtValor.Text = cupom.Valor.ToString();
            cbParceiro.SelectedItem = cupom.Parceiro;
            dateValidade.Text = cupom.DataValidade.ToString();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.cupom = ObterCupom();

            Result resultado = onGravarRegistro(cupom);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void CarregarParceiros(List<Parceiro> parceiros)
        {
            foreach(Parceiro parceiro in parceiros)
            {
                cbParceiro.Items.Add(parceiro);
            }
        }

    }
}
