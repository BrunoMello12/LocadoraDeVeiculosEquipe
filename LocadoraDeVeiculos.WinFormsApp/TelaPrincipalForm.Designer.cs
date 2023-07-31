namespace LocadoraDeVeiculos.WinFormsApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            aluguelToolStripMenuItem = new ToolStripMenuItem();
            automóvelToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            condutorToolStripMenuItem = new ToolStripMenuItem();
            cupomToolStripMenuItem = new ToolStripMenuItem();
            funcionárioToolStripMenuItem = new ToolStripMenuItem();
            taxasEServiçosToolStripMenuItem = new ToolStripMenuItem();
            planoDeCobrançaToolStripMenuItem = new ToolStripMenuItem();
            grupoDeAutomóveisToolStripMenuItem = new ToolStripMenuItem();
            parceiroToolStripMenuItem = new ToolStripMenuItem();
            toolBox = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            lblTipoCadastro = new ToolStripLabel();
            panelRegistros = new Panel();
            statusStrip1 = new StatusStrip();
            labelRodape = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            toolBox.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(567, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aluguelToolStripMenuItem, automóvelToolStripMenuItem, clienteToolStripMenuItem, condutorToolStripMenuItem, cupomToolStripMenuItem, funcionárioToolStripMenuItem, taxasEServiçosToolStripMenuItem, planoDeCobrançaToolStripMenuItem, grupoDeAutomóveisToolStripMenuItem, parceiroToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // aluguelToolStripMenuItem
            // 
            aluguelToolStripMenuItem.Name = "aluguelToolStripMenuItem";
            aluguelToolStripMenuItem.Size = new Size(190, 22);
            aluguelToolStripMenuItem.Text = "Aluguel";
            aluguelToolStripMenuItem.Click += aluguelToolStripMenuItem_Click;
            // 
            // automóvelToolStripMenuItem
            // 
            automóvelToolStripMenuItem.Name = "automóvelToolStripMenuItem";
            automóvelToolStripMenuItem.Size = new Size(190, 22);
            automóvelToolStripMenuItem.Text = "Automóvel";
            automóvelToolStripMenuItem.Click += automóvelToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(190, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // condutorToolStripMenuItem
            // 
            condutorToolStripMenuItem.Name = "condutorToolStripMenuItem";
            condutorToolStripMenuItem.Size = new Size(190, 22);
            condutorToolStripMenuItem.Text = "Condutor";
            condutorToolStripMenuItem.Click += condutorToolStripMenuItem_Click;
            // 
            // cupomToolStripMenuItem
            // 
            cupomToolStripMenuItem.Name = "cupomToolStripMenuItem";
            cupomToolStripMenuItem.Size = new Size(190, 22);
            cupomToolStripMenuItem.Text = "Cupom";
            cupomToolStripMenuItem.Click += cupomToolStripMenuItem_Click;
            // 
            // funcionárioToolStripMenuItem
            // 
            funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            funcionárioToolStripMenuItem.Size = new Size(190, 22);
            funcionárioToolStripMenuItem.Text = "Funcionário";
            funcionárioToolStripMenuItem.Click += funcionárioToolStripMenuItem_Click;
            // 
            // taxasEServiçosToolStripMenuItem
            // 
            taxasEServiçosToolStripMenuItem.Name = "taxasEServiçosToolStripMenuItem";
            taxasEServiçosToolStripMenuItem.Size = new Size(190, 22);
            taxasEServiçosToolStripMenuItem.Text = "Taxas ou Serviços";
            taxasEServiçosToolStripMenuItem.Click += taxasEServiçosToolStripMenuItem_Click;
            // 
            // planoDeCobrançaToolStripMenuItem
            // 
            planoDeCobrançaToolStripMenuItem.Name = "planoDeCobrançaToolStripMenuItem";
            planoDeCobrançaToolStripMenuItem.Size = new Size(190, 22);
            planoDeCobrançaToolStripMenuItem.Text = "Plano De Cobrança";
            planoDeCobrançaToolStripMenuItem.Click += planoDeCobrançaToolStripMenuItem_Click;
            // 
            // grupoDeAutomóveisToolStripMenuItem
            // 
            grupoDeAutomóveisToolStripMenuItem.Name = "grupoDeAutomóveisToolStripMenuItem";
            grupoDeAutomóveisToolStripMenuItem.Size = new Size(190, 22);
            grupoDeAutomóveisToolStripMenuItem.Text = "Grupo de Automóveis";
            grupoDeAutomóveisToolStripMenuItem.Click += grupoDeAutomóveisToolStripMenuItem_Click;
            // 
            // parceiroToolStripMenuItem
            // 
            parceiroToolStripMenuItem.Name = "parceiroToolStripMenuItem";
            parceiroToolStripMenuItem.Size = new Size(190, 22);
            parceiroToolStripMenuItem.Text = "Parceiro";
            parceiroToolStripMenuItem.Click += parceiroToolStripMenuItem_Click;
            // 
            // toolBox
            // 
            toolBox.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, toolStripSeparator1, lblTipoCadastro });
            toolBox.Location = new Point(0, 24);
            toolBox.Name = "toolBox";
            toolBox.Size = new Size(567, 45);
            toolBox.TabIndex = 1;
            toolBox.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Image = Properties.Resources.add_FILL0_wght400_GRAD0_opsz24;
            btnAdicionar.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Padding = new Padding(7);
            btnAdicionar.Size = new Size(42, 42);
            btnAdicionar.Text = "toolStripButton1";
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = Properties.Resources.edit_FILL0_wght400_GRAD0_opsz24;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(7);
            btnEditar.Size = new Size(42, 42);
            btnEditar.Text = "toolStripButton2";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = Properties.Resources.delete_FILL0_wght400_GRAD0_opsz24;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(7);
            btnExcluir.Size = new Size(42, 42);
            btnExcluir.Text = "toolStripButton3";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 45);
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(77, 42);
            lblTipoCadastro.Text = "TipoCadastro";
            // 
            // panelRegistros
            // 
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Location = new Point(0, 69);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(567, 280);
            panelRegistros.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { labelRodape });
            statusStrip1.Location = new Point(0, 327);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(567, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // labelRodape
            // 
            labelRodape.Name = "labelRodape";
            labelRodape.Size = new Size(52, 17);
            labelRodape.Text = "[rodapé]";
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 349);
            Controls.Add(statusStrip1);
            Controls.Add(panelRegistros);
            Controls.Add(toolBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            Text = "Locadora De Automóveis";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolBox.ResumeLayout(false);
            toolBox.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStrip toolBox;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private Panel panelRegistros;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelRodape;
        private ToolStripMenuItem aluguelToolStripMenuItem;
        private ToolStripMenuItem automóvelToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem condutorToolStripMenuItem;
        private ToolStripMenuItem cupomToolStripMenuItem;
        private ToolStripMenuItem funcionárioToolStripMenuItem;
        private ToolStripMenuItem taxasEServiçosToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel lblTipoCadastro;
        private ToolStripMenuItem planoDeCobrançaToolStripMenuItem;
        private ToolStripMenuItem grupoDeAutomóveisToolStripMenuItem;
        private ToolStripMenuItem parceiroToolStripMenuItem;
    }
}