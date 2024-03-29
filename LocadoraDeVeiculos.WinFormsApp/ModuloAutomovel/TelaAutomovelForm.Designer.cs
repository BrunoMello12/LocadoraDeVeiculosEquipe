﻿namespace LocadoraDeVeiculos.WinFormsApp.ModuloAutomovel
{
    partial class TelaAutomovelForm
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
            txtMarca = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnBuscar = new Button();
            label4 = new Label();
            picFotoCarro = new PictureBox();
            label5 = new Label();
            txtCor = new TextBox();
            cbGrpAutomoveis = new ComboBox();
            txtModelo = new TextBox();
            cbTipoCombustivel = new ComboBox();
            label6 = new Label();
            txtCapacidadeEmLitros = new TextBox();
            label7 = new Label();
            lblPlaca = new Label();
            txtPlaca = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)picFotoCarro).BeginInit();
            SuspendLayout();
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(271, 414);
            txtMarca.Margin = new Padding(5, 6, 5, 6);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(205, 35);
            txtMarca.TabIndex = 22;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(207, 618);
            btnGravar.Margin = new Padding(5, 6, 5, 6);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(130, 68);
            btnGravar.TabIndex = 21;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(348, 618);
            btnCancelar.Margin = new Padding(5, 6, 5, 6);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 68);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(182, 420);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 30);
            label3.TabIndex = 18;
            label3.Text = "Marca: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 364);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 30);
            label2.TabIndex = 17;
            label2.Text = "Modelo: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 190);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(226, 30);
            label1.TabIndex = 16;
            label1.Text = "Grupo de Automóveis: ";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(326, 52);
            btnBuscar.Margin = new Padding(5, 6, 5, 6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(153, 50);
            btnBuscar.TabIndex = 24;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 62);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 30);
            label4.TabIndex = 25;
            label4.Text = "Foto: ";
            // 
            // picFotoCarro
            // 
            picFotoCarro.Location = new Point(94, 24);
            picFotoCarro.Margin = new Padding(5, 6, 5, 6);
            picFotoCarro.Name = "picFotoCarro";
            picFotoCarro.Size = new Size(221, 110);
            picFotoCarro.TabIndex = 26;
            picFotoCarro.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(206, 478);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(56, 30);
            label5.TabIndex = 27;
            label5.Text = "Cor: ";
            // 
            // txtCor
            // 
            txtCor.Location = new Point(271, 472);
            txtCor.Margin = new Padding(5, 6, 5, 6);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(205, 35);
            txtCor.TabIndex = 28;
            // 
            // cbGrpAutomoveis
            // 
            cbGrpAutomoveis.FormattingEnabled = true;
            cbGrpAutomoveis.Location = new Point(271, 184);
            cbGrpAutomoveis.Margin = new Padding(5, 6, 5, 6);
            cbGrpAutomoveis.Name = "cbGrpAutomoveis";
            cbGrpAutomoveis.Size = new Size(205, 38);
            cbGrpAutomoveis.TabIndex = 29;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(271, 358);
            txtModelo.Margin = new Padding(5, 6, 5, 6);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(205, 35);
            txtModelo.TabIndex = 30;
            // 
            // cbTipoCombustivel
            // 
            cbTipoCombustivel.FormattingEnabled = true;
            cbTipoCombustivel.Location = new Point(271, 242);
            cbTipoCombustivel.Margin = new Padding(5, 6, 5, 6);
            cbTipoCombustivel.Name = "cbTipoCombustivel";
            cbTipoCombustivel.Size = new Size(205, 38);
            cbTipoCombustivel.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 252);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(207, 30);
            label6.TabIndex = 31;
            label6.Text = "Tipo de Combustível:";
            // 
            // txtCapacidadeEmLitros
            // 
            txtCapacidadeEmLitros.Location = new Point(271, 300);
            txtCapacidadeEmLitros.Margin = new Padding(5, 6, 5, 6);
            txtCapacidadeEmLitros.Name = "txtCapacidadeEmLitros";
            txtCapacidadeEmLitros.Size = new Size(205, 35);
            txtCapacidadeEmLitros.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 306);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(223, 30);
            label7.TabIndex = 33;
            label7.Text = "Capacidade Em Litros: ";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(206, 536);
            lblPlaca.Margin = new Padding(5, 0, 5, 0);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(73, 30);
            lblPlaca.TabIndex = 35;
            lblPlaca.Text = "Placa: ";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(271, 531);
            txtPlaca.Mask = "AAA-0000";
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(205, 35);
            txtPlaca.TabIndex = 36;
            // 
            // TelaAutomovelForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 710);
            Controls.Add(txtPlaca);
            Controls.Add(lblPlaca);
            Controls.Add(txtCapacidadeEmLitros);
            Controls.Add(label7);
            Controls.Add(cbTipoCombustivel);
            Controls.Add(label6);
            Controls.Add(txtModelo);
            Controls.Add(cbGrpAutomoveis);
            Controls.Add(txtCor);
            Controls.Add(label5);
            Controls.Add(picFotoCarro);
            Controls.Add(label4);
            Controls.Add(btnBuscar);
            Controls.Add(txtMarca);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TelaAutomovelForm";
            Text = "Cadastro de Automovel";
            ((System.ComponentModel.ISupportInitialize)picFotoCarro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateAdmissao;
        private TextBox txtMarca;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtNome;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnBuscar;
        private Label label4;
        private PictureBox picFotoCarro;
        private Label label5;
        private TextBox txtCor;
        private ComboBox cbGrpAutomoveis;
        private TextBox txtModelo;
        private ComboBox cbTipoCombustivel;
        private Label label6;
        private TextBox txtCapacidadeEmLitros;
        private Label label7;
        private Label lblPlaca;
        private MaskedTextBox txtPlaca;
    }
}