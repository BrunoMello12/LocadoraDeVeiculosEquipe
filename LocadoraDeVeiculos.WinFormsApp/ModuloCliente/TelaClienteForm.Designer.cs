namespace LocadoraDeVeiculos.WinFormsApp.ModuloCliente
{
    partial class TelaClienteForm
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
            txtNome = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtCpf = new TextBox();
            txtBairro = new TextBox();
            label5 = new Label();
            txtEstado = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            label4 = new Label();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            rdbFisica = new RadioButton();
            rdbJuridica = new RadioButton();
            label8 = new Label();
            txtCnpj = new TextBox();
            label9 = new Label();
            txtCidade = new TextBox();
            txtRua = new TextBox();
            label10 = new Label();
            txtNumero = new TextBox();
            label11 = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(167, 33);
            txtNome.Margin = new Padding(4, 5, 4, 5);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(327, 31);
            txtNome.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 190);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(134, 25);
            label7.TabIndex = 45;
            label7.Text = "Tipo de Cliente:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(80, 133);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 43;
            label6.Text = "Telefone:";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(160, 247);
            txtCpf.Margin = new Padding(4, 5, 4, 5);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(131, 31);
            txtCpf.TabIndex = 42;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(160, 343);
            txtBairro.Margin = new Padding(4, 5, 4, 5);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(334, 31);
            txtBairro.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 348);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 39;
            label5.Text = "Bairro:";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(160, 295);
            txtEstado.Margin = new Padding(4, 5, 4, 5);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(67, 31);
            txtEstado.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 300);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 37;
            label3.Text = "Estado: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 252);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 36;
            label2.Text = "CPF:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 35;
            label1.Text = "Nome:";
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(293, 502);
            btnGravar.Margin = new Padding(4, 5, 4, 5);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(109, 57);
            btnGravar.TabIndex = 48;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(410, 502);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 57);
            btnCancelar.TabIndex = 47;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 87);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 49;
            label4.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(167, 82);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(327, 31);
            txtEmail.TabIndex = 50;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(167, 128);
            txtTelefone.Margin = new Padding(4, 5, 4, 5);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(171, 31);
            txtTelefone.TabIndex = 51;
            // 
            // rdbFisica
            // 
            rdbFisica.AutoSize = true;
            rdbFisica.Location = new Point(167, 187);
            rdbFisica.Margin = new Padding(4, 5, 4, 5);
            rdbFisica.Name = "rdbFisica";
            rdbFisica.Size = new Size(138, 29);
            rdbFisica.TabIndex = 52;
            rdbFisica.TabStop = true;
            rdbFisica.Text = "Pessoa Física";
            rdbFisica.UseVisualStyleBackColor = true;
            // 
            // rdbJuridica
            // 
            rdbJuridica.AutoSize = true;
            rdbJuridica.Location = new Point(317, 190);
            rdbJuridica.Margin = new Padding(4, 5, 4, 5);
            rdbJuridica.Name = "rdbJuridica";
            rdbJuridica.Size = new Size(154, 29);
            rdbJuridica.TabIndex = 53;
            rdbJuridica.TabStop = true;
            rdbJuridica.Text = "Pessoa Jurídica";
            rdbJuridica.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(301, 252);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(55, 25);
            label8.TabIndex = 54;
            label8.Text = "CNPJ:";
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(363, 247);
            txtCnpj.Margin = new Padding(4, 5, 4, 5);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(131, 31);
            txtCnpj.TabIndex = 55;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(237, 300);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(71, 25);
            label9.TabIndex = 56;
            label9.Text = "Cidade:";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(317, 295);
            txtCidade.Margin = new Padding(4, 5, 4, 5);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(177, 31);
            txtCidade.TabIndex = 57;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(160, 392);
            txtRua.Margin = new Padding(4, 5, 4, 5);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(334, 31);
            txtRua.TabIndex = 59;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(109, 397);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(46, 25);
            label10.TabIndex = 58;
            label10.Text = "Rua:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(160, 440);
            txtNumero.Margin = new Padding(4, 5, 4, 5);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(131, 31);
            txtNumero.TabIndex = 61;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(74, 445);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(81, 25);
            label11.TabIndex = 60;
            label11.Text = "Número:";
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 578);
            Controls.Add(txtNumero);
            Controls.Add(label11);
            Controls.Add(txtRua);
            Controls.Add(label10);
            Controls.Add(txtCidade);
            Controls.Add(label9);
            Controls.Add(txtCnpj);
            Controls.Add(label8);
            Controls.Add(rdbJuridica);
            Controls.Add(rdbFisica);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(txtNome);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtCpf);
            Controls.Add(txtBairro);
            Controls.Add(label5);
            Controls.Add(txtEstado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "TelaClienteForm";
            Text = "Cadastro de Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label label7;
        private Label label6;
        private TextBox txtCpf;
        private TextBox txtBairro;
        private Label label5;
        private TextBox txtEstado;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGravar;
        private Button btnCancelar;
        private Label label4;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private RadioButton rdbFisica;
        private RadioButton rdbJuridica;
        private Label label8;
        private TextBox txtCnpj;
        private Label label9;
        private TextBox txtCidade;
        private TextBox txtRua;
        private Label label10;
        private TextBox txtNumero;
        private Label label11;
    }
}