namespace LocadoraDeVeiculos.WinFormsApp.ModuloTaxasServicos
{
    partial class TelaTaxasServicosForm
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
            rdbCobranca = new RadioButton();
            rdbPrecoFixo = new RadioButton();
            txtPreco = new TextBox();
            label4 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtNome = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // rdbCobranca
            // 
            rdbCobranca.AutoSize = true;
            rdbCobranca.Location = new Point(133, 33);
            rdbCobranca.Name = "rdbCobranca";
            rdbCobranca.Size = new Size(109, 19);
            rdbCobranca.TabIndex = 61;
            rdbCobranca.TabStop = true;
            rdbCobranca.Text = "Cobrança Diária";
            rdbCobranca.UseVisualStyleBackColor = true;
            // 
            // rdbPrecoFixo
            // 
            rdbPrecoFixo.AutoSize = true;
            rdbPrecoFixo.Location = new Point(28, 31);
            rdbPrecoFixo.Name = "rdbPrecoFixo";
            rdbPrecoFixo.Size = new Size(80, 19);
            rdbPrecoFixo.TabIndex = 60;
            rdbPrecoFixo.TabStop = true;
            rdbPrecoFixo.Text = "Preço Fixo";
            rdbPrecoFixo.UseVisualStyleBackColor = true;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(70, 52);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(94, 23);
            txtPreco.TabIndex = 59;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 55);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 58;
            label4.Text = "Preço:";
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(110, 192);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(76, 34);
            btnGravar.TabIndex = 57;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(192, 192);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(76, 34);
            btnCancelar.TabIndex = 56;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(70, 23);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(194, 23);
            txtNome.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 26);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 54;
            label1.Text = "Nome:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbCobranca);
            groupBox1.Controls.Add(rdbPrecoFixo);
            groupBox1.Location = new Point(12, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(252, 73);
            groupBox1.TabIndex = 62;
            groupBox1.TabStop = false;
            groupBox1.Text = "Plano de Calculo";
            // 
            // TelaTaxasServicosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 238);
            Controls.Add(groupBox1);
            Controls.Add(txtPreco);
            Controls.Add(label4);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "TelaTaxasServicosForm";
            Text = "Cadastro de Taxa e Serviços";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdbCobranca;
        private RadioButton rdbPrecoFixo;
        private TextBox txtPreco;
        private Label label4;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtNome;
        private Label label1;
        private GroupBox groupBox1;
    }
}