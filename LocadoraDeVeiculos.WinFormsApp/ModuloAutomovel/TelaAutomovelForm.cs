using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomoveis;
using LocadoraDeVeiculos.WinFormsApp.Compartilhado;
using System.Collections;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloAutomovel
{
    public partial class TelaAutomovelForm : Form
    {
        Automovel automovel;

        public event GravarRegistroDelegate<Automovel> onGravarRegistro;

        public TelaAutomovelForm(List<GrupoAutomoveis> grupoDeAutomoveis)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            CarregarGrupoDeAltomoveis(grupoDeAutomoveis);
            CarregarTipoCombustivel();
        }

        public Automovel ObterAutomovel()
        {
            decimal capacidadelitros;

            automovel.Placa = txtPlaca.Text;
            automovel.Marca = txtMarca.Text;
            automovel.Cor = txtCor.Text;
            automovel.Modelo = txtModelo.Text;

            decimal.TryParse(txtCapacidadeEmLitros.Text, out capacidadelitros);
            automovel.CapacidadeLitros = capacidadelitros;

            automovel.GrupoDoAutomovel = (GrupoAutomoveis)cbGrpAutomoveis.SelectedItem;
            automovel.TipoCombustivel = (TipoCombustivelEnum)cbTipoCombustivel.SelectedItem;

            return automovel;
        }

        public void ConfigurarAutomovel(Automovel automovel)
        {
            this.automovel = automovel;

            txtPlaca.Text = automovel.Placa;
            txtMarca.Text = automovel.Marca;
            txtCor.Text = automovel.Cor;
            txtModelo.Text = automovel.Modelo;
            txtCapacidadeEmLitros.Text = automovel.CapacidadeLitros.ToString();
            cbGrpAutomoveis.SelectedItem = automovel.GrupoDoAutomovel;
            cbTipoCombustivel.SelectedItem = automovel.TipoCombustivel;
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
        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.automovel = ObterAutomovel();

            Result resultado = onGravarRegistro(automovel);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
