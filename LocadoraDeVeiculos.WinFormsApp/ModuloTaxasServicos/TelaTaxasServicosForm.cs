using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloTaxasServicos;
using LocadoraDeVeiculos.WinFormsApp.Compartilhado;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloTaxasServicos
{
    public partial class TelaTaxasServicosForm : Form
    {
        private TaxasServicos taxasServicos;

        public event GravarRegistroDelegate<TaxasServicos> onGravarRegistro;

        public TelaTaxasServicosForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public TaxasServicos ObterTaxasServicos()
        {
            taxasServicos.Nome = txtNome.Text;

            taxasServicos.Preco = decimal.Parse(txtPreco.Text);

            return taxasServicos;
        }

        public void ConfigurarTaxasServicos(TaxasServicos taxasServicos)
        {
            this.taxasServicos = taxasServicos;

            txtNome.Text = taxasServicos.Nome;
            txtPreco.Text = taxasServicos.Preco.ToString();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.taxasServicos = ObterTaxasServicos();

            Result resultado = onGravarRegistro(taxasServicos);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
