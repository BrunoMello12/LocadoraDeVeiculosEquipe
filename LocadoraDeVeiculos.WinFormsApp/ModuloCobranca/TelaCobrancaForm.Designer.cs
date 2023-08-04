namespace LocadoraDeVeiculos.WinFormsApp.ModuloCobranca
{
    partial class TelaCobrancaForm
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
            btnGravar = new Button();
            btnCancelar = new Button();
            txtPrecoDiaria = new TextBox();
            label1 = new Label();
            cbGrupoAutomoveis = new ComboBox();
            groupBox1 = new GroupBox();
            txtKmDisponivel = new TextBox();
            label5 = new Label();
            txtPrecoExtrapolado = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cbTipoPlano = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(329, 402);
            btnGravar.Margin = new Padding(5, 6, 5, 6);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(131, 68);
            btnGravar.TabIndex = 13;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(469, 402);
            btnCancelar.Margin = new Padding(5, 6, 5, 6);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(131, 68);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtPrecoDiaria
            // 
            txtPrecoDiaria.Location = new Point(289, 102);
            txtPrecoDiaria.Margin = new Padding(5, 6, 5, 6);
            txtPrecoDiaria.Name = "txtPrecoDiaria";
            txtPrecoDiaria.Size = new Size(240, 35);
            txtPrecoDiaria.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 30);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(220, 30);
            label1.TabIndex = 10;
            label1.Text = "Grupo de Automóveis:";
            // 
            // cbGrupoAutomoveis
            // 
            cbGrupoAutomoveis.FormattingEnabled = true;
            cbGrupoAutomoveis.Location = new Point(257, 24);
            cbGrupoAutomoveis.Margin = new Padding(5, 6, 5, 6);
            cbGrupoAutomoveis.Name = "cbGrupoAutomoveis";
            cbGrupoAutomoveis.Size = new Size(320, 38);
            cbGrupoAutomoveis.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtKmDisponivel);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPrecoExtrapolado);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbTipoPlano);
            groupBox1.Controls.Add(txtPrecoDiaria);
            groupBox1.Location = new Point(31, 82);
            groupBox1.Margin = new Padding(5, 6, 5, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 6, 5, 6);
            groupBox1.Size = new Size(544, 296);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configuração de Planos";
            // 
            // txtKmDisponivel
            // 
            txtKmDisponivel.Enabled = false;
            txtKmDisponivel.Location = new Point(289, 218);
            txtKmDisponivel.Margin = new Padding(5, 6, 5, 6);
            txtKmDisponivel.Name = "txtKmDisponivel";
            txtKmDisponivel.Size = new Size(240, 35);
            txtKmDisponivel.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(124, 224);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(159, 30);
            label5.TabIndex = 20;
            label5.Text = "Km Disponíveis:";
            // 
            // txtPrecoExtrapolado
            // 
            txtPrecoExtrapolado.Enabled = false;
            txtPrecoExtrapolado.Location = new Point(289, 160);
            txtPrecoExtrapolado.Margin = new Padding(5, 6, 5, 6);
            txtPrecoExtrapolado.Name = "txtPrecoExtrapolado";
            txtPrecoExtrapolado.Size = new Size(240, 35);
            txtPrecoExtrapolado.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 166);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(270, 30);
            label4.TabIndex = 18;
            label4.Text = "Preço Por Km (Extrapolado):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 105);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(130, 30);
            label3.TabIndex = 17;
            label3.Text = "Preço Diária:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 50);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 30);
            label2.TabIndex = 16;
            label2.Text = "Tipo de Plano:";
            // 
            // cbTipoPlano
            // 
            cbTipoPlano.FormattingEnabled = true;
            cbTipoPlano.Location = new Point(289, 44);
            cbTipoPlano.Margin = new Padding(5, 6, 5, 6);
            cbTipoPlano.Name = "cbTipoPlano";
            cbTipoPlano.Size = new Size(240, 38);
            cbTipoPlano.TabIndex = 16;
            cbTipoPlano.SelectedIndexChanged += cbTipoPlano_SelectedIndexChanged;
            // 
            // TelaCobrancaForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 494);
            Controls.Add(groupBox1);
            Controls.Add(cbGrupoAutomoveis);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(label1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TelaCobrancaForm";
            Text = "Cadastro de Cobranca";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtPrecoDiaria;
        private Label label1;
        private ComboBox cbGrupoAutomoveis;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox cbTipoPlano;
        private Label label4;
        private Label label3;
        private TextBox txtKmDisponivel;
        private Label label5;
        private TextBox txtPrecoExtrapolado;
    }
}