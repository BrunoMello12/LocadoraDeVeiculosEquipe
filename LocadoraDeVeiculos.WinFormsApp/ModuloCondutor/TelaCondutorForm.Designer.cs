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
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            cbCliente = new ComboBox();
            chEhCondutor = new CheckBox();
            label4 = new Label();
            label6 = new Label();
            dateValidade = new DateTimePicker();
            label7 = new Label();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            txtCnh = new MaskedTextBox();
            txtCpf = new MaskedTextBox();
            txtTelefone = new MaskedTextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 288);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 30);
            label5.TabIndex = 66;
            label5.Text = "Telefone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 230);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 30);
            label3.TabIndex = 64;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 172);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 30);
            label2.TabIndex = 63;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 58);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 30);
            label1.TabIndex = 62;
            label1.Text = "Cliente:";
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(372, 516);
            btnGravar.Margin = new Padding(5, 6, 5, 6);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(130, 68);
            btnGravar.TabIndex = 86;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(513, 516);
            btnCancelar.Margin = new Padding(5, 6, 5, 6);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 68);
            btnCancelar.TabIndex = 85;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(147, 52);
            cbCliente.Margin = new Padding(5, 6, 5, 6);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(391, 38);
            cbCliente.TabIndex = 87;
            // 
            // chEhCondutor
            // 
            chEhCondutor.AutoSize = true;
            chEhCondutor.Location = new Point(147, 116);
            chEhCondutor.Margin = new Padding(5, 6, 5, 6);
            chEhCondutor.Name = "chEhCondutor";
            chEhCondutor.Size = new Size(210, 34);
            chEhCondutor.TabIndex = 88;
            chEhCondutor.Text = "Cliente é condutor";
            chEhCondutor.UseVisualStyleBackColor = true;
            chEhCondutor.CheckedChanged += chEhCondutor_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(329, 288);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 30);
            label4.TabIndex = 89;
            label4.Text = "CPF:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 346);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(62, 30);
            label6.TabIndex = 91;
            label6.Text = "CNH:";
            // 
            // dateValidade
            // 
            dateValidade.Format = DateTimePickerFormat.Short;
            dateValidade.Location = new Point(147, 398);
            dateValidade.Margin = new Padding(5, 6, 5, 6);
            dateValidade.Name = "dateValidade";
            dateValidade.Size = new Size(169, 35);
            dateValidade.TabIndex = 93;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 406);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(96, 30);
            label7.TabIndex = 94;
            label7.Text = "Validade:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(147, 224);
            txtEmail.Margin = new Padding(5, 6, 5, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(391, 35);
            txtEmail.TabIndex = 95;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(147, 166);
            txtNome.Margin = new Padding(5, 6, 5, 6);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(391, 35);
            txtNome.TabIndex = 96;
            // 
            // txtCnh
            // 
            txtCnh.Location = new Point(147, 340);
            txtCnh.Margin = new Padding(5, 6, 5, 6);
            txtCnh.Mask = "99,999,999/9999-99";
            txtCnh.Name = "txtCnh";
            txtCnh.Size = new Size(169, 35);
            txtCnh.TabIndex = 99;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(382, 282);
            txtCpf.Margin = new Padding(5, 6, 5, 6);
            txtCpf.Mask = "999,999,999-99";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(157, 35);
            txtCpf.TabIndex = 98;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(147, 282);
            txtTelefone.Margin = new Padding(5, 6, 5, 6);
            txtTelefone.Mask = "(99) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(169, 35);
            txtTelefone.TabIndex = 97;
            // 
            // TelaCondutorForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 608);
            Controls.Add(txtCnh);
            Controls.Add(txtCpf);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(dateValidade);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(chEhCondutor);
            Controls.Add(cbCliente);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(5, 6, 5, 6);
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
        private Label label4;
        private Label label6;
        private DateTimePicker dateValidade;
        private Label label7;
        private TextBox txtEmail;
        private TextBox txtNome;
        private MaskedTextBox txtCnh;
        private MaskedTextBox txtCpf;
        private MaskedTextBox txtTelefone;
    }
}