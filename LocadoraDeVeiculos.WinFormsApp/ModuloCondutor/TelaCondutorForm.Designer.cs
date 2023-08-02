namespace LocadoraDeVeiculos.WinFormsApp.ModuloCondutor
{
    partial class TelaCondutorForm
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
            txtTelefone = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            cbCliente = new ComboBox();
            chEhCondutor = new CheckBox();
            txtCpf = new TextBox();
            label4 = new Label();
            txtCnh = new TextBox();
            label6 = new Label();
            dateValidade = new DateTimePicker();
            label7 = new Label();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            SuspendLayout();
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(123, 235);
            txtTelefone.Margin = new Padding(4, 5, 4, 5);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(141, 31);
            txtTelefone.TabIndex = 67;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 240);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 66;
            label5.Text = "Telefone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 192);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 64;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 143);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 63;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 62;
            label1.Text = "Cliente:";
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(310, 430);
            btnGravar.Margin = new Padding(4, 5, 4, 5);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(109, 57);
            btnGravar.TabIndex = 86;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(427, 430);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 57);
            btnCancelar.TabIndex = 85;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(123, 43);
            cbCliente.Margin = new Padding(4, 5, 4, 5);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(327, 33);
            cbCliente.TabIndex = 87;
            // 
            // chEhCondutor
            // 
            chEhCondutor.AutoSize = true;
            chEhCondutor.Location = new Point(123, 97);
            chEhCondutor.Margin = new Padding(4, 5, 4, 5);
            chEhCondutor.Name = "chEhCondutor";
            chEhCondutor.Size = new Size(183, 29);
            chEhCondutor.TabIndex = 88;
            chEhCondutor.Text = "Cliente é condutor";
            chEhCondutor.UseVisualStyleBackColor = true;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(327, 235);
            txtCpf.Margin = new Padding(4, 5, 4, 5);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(123, 31);
            txtCpf.TabIndex = 90;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(274, 240);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 89;
            label4.Text = "CPF:";
            // 
            // txtCnh
            // 
            txtCnh.Location = new Point(123, 283);
            txtCnh.Margin = new Padding(4, 5, 4, 5);
            txtCnh.Name = "txtCnh";
            txtCnh.Size = new Size(123, 31);
            txtCnh.TabIndex = 92;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 288);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 25);
            label6.TabIndex = 91;
            label6.Text = "CNH:";
            // 
            // dateValidade
            // 
            dateValidade.Format = DateTimePickerFormat.Short;
            dateValidade.Location = new Point(123, 332);
            dateValidade.Margin = new Padding(4, 5, 4, 5);
            dateValidade.Name = "dateValidade";
            dateValidade.Size = new Size(175, 31);
            dateValidade.TabIndex = 93;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 338);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(83, 25);
            label7.TabIndex = 94;
            label7.Text = "Validade:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(123, 187);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(327, 31);
            txtEmail.TabIndex = 95;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(123, 138);
            txtNome.Margin = new Padding(4, 5, 4, 5);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(327, 31);
            txtNome.TabIndex = 96;
            // 
            // TelaCondutorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 507);
            Controls.Add(txtNome);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(dateValidade);
            Controls.Add(txtCnh);
            Controls.Add(label6);
            Controls.Add(txtCpf);
            Controls.Add(label4);
            Controls.Add(chEhCondutor);
            Controls.Add(cbCliente);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(txtTelefone);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "TelaCondutorForm";
            Text = "Cadastro de Condutor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCidade;
        private Label label9;
        private TextBox txtCnpj;
        private Label label8;
        private RadioButton rdbJuridica;
        private RadioButton rdbFisica;
        private TextBox txtTelefone;
        private TextBox txtBairro;
        private Label label5;
        private TextBox txtEstado;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGravar;
        private Button btnCancelar;
        private ComboBox cbCliente;
        private CheckBox chEhCondutor;
        private TextBox txtCpf;
        private Label label4;
        private TextBox txtCnh;
        private Label label6;
        private DateTimePicker dateValidade;
        private Label label7;
        private TextBox txtEmail;
        private TextBox txtNome;
    }
}