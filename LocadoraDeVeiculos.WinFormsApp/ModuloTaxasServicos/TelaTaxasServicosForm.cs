using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloTaxasServicos;
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
