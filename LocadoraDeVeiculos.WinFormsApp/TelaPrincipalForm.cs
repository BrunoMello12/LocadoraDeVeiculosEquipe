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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LocadoraDeVeiculos.WinFormsApp
{
    public partial class TelaPrincipalForm : Form
    {
        private Dictionary<string, ControladorBase> controladores;
        private ControladorBase controlador;

        public TelaPrincipalForm()
        {
            InitializeComponent();
        }

        public static TelaPrincipalForm Instancia
        {
            get;
            private set;
        }

        public void AtualizarRodape()
        {
            string mensagemRodape = controlador.ObterMensagemRodape();

            AtualizarRodape(mensagemRodape);
        }

        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        private void ConfigurarBotoes(ConfiguracaoToolBoxBase configuracao)
        {
            btnAdicionar.Enabled = configuracao.InserirHabilitado;
            btnEditar.Enabled = configuracao.EditarHabilitado;
            btnExcluir.Enabled = configuracao.ExcluirHabilitado;
        }

        private void ConfigurarTooltips(ConfiguracaoToolBoxBase configuracao)
        {
            btnAdicionar.ToolTipText = configuracao.TooltipInserir;
            btnEditar.ToolTipText = configuracao.TooltipEditar;
            btnExcluir.ToolTipText = configuracao.TooltipExcluir;
        }

        private void ConfigurarTelaPrincipal(ControladorBase controlador)
        {
            this.controlador = controlador;

            ConfigurarToolbox();

            ConfigurarListagem();

            string mensagemRodape = controlador.ObterMensagemRodape();

            AtualizarRodape(mensagemRodape);
        }

        private void ConfigurarToolbox()
        {
            ConfiguracaoToolBoxBase configuracao = controlador.ObtemConfiguracaoToolbox();

            if (configuracao != null)
            {
                toolBox.Enabled = true;

                lblTipoCadastro.Text = configuracao.TipoCadastro;

                ConfigurarTooltips(configuracao);

                ConfigurarBotoes(configuracao);
            }
        }

        private void ConfigurarListagem()
        {
            AtualizarRodape("");

            var listagemControl = controlador.ObtemListagem();

            panelRegistros.Controls.Clear();

            listagemControl.Dock = DockStyle.Fill;

            panelRegistros.Controls.Add(listagemControl);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void aluguelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorAluguel"]);
        }

        private void automóvelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorAutomovel"]);
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorCliente"]);
        }

        private void condutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorCondutor"]);
        }

        private void cupomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorCupom"]);
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorFuncionario"]);
        }

        private void taxasEServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorTaxas"]);
        }

        private void planoDeCobrançaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorPlanoCobranca"]);
        }

        private void grupoDeAutomóveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorGrupoAutomoveis"]);
        }

        private void parceiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorParceiro"]);
        }
    }
}
