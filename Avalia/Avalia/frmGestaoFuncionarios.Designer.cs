namespace Avalia
{
    partial class frmGestaoFuncionarios
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblNivelDeAcesso = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mskBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbBoxNivelDeAcesso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(852, 481);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtConfirmaSenha);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnCadastrar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbBoxNivelDeAcesso);
            this.tabPage1.Controls.Add(this.lblNivelDeAcesso);
            this.tabPage1.Controls.Add(this.txtSenha);
            this.tabPage1.Controls.Add(this.lblSenha);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.mskTelefone);
            this.tabPage1.Controls.Add(this.lblTelefone);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.lblEmail);
            this.tabPage1.Controls.Add(this.mskBoxCpf);
            this.tabPage1.Controls.Add(this.lblCpf);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.lblNome);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(844, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblNivelDeAcesso
            // 
            this.lblNivelDeAcesso.AutoSize = true;
            this.lblNivelDeAcesso.Location = new System.Drawing.Point(11, 327);
            this.lblNivelDeAcesso.Name = "lblNivelDeAcesso";
            this.lblNivelDeAcesso.Size = new System.Drawing.Size(90, 13);
            this.lblNivelDeAcesso.TabIndex = 11;
            this.lblNivelDeAcesso.Text = "Nível de Acesso*";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(14, 288);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(197, 20);
            this.txtSenha.TabIndex = 10;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(11, 272);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(42, 13);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "Senha*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Defina abaixo uma senha para acesso";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(14, 211);
            this.mskTelefone.Mask = "(00) - 00000 - 0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(197, 20);
            this.mskTelefone.TabIndex = 7;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(11, 195);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(11, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(328, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(8, 101);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email*";
            // 
            // mskBoxCpf
            // 
            this.mskBoxCpf.Location = new System.Drawing.Point(11, 165);
            this.mskBoxCpf.Mask = "000.000.000-00";
            this.mskBoxCpf.Name = "mskBoxCpf";
            this.mskBoxCpf.Size = new System.Drawing.Size(197, 20);
            this.mskBoxCpf.TabIndex = 3;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(11, 149);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(31, 13);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "CPF*";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(11, 68);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(328, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(8, 52);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome*";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(844, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edição";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbBoxNivelDeAcesso
            // 
            this.cmbBoxNivelDeAcesso.FormattingEnabled = true;
            this.cmbBoxNivelDeAcesso.Items.AddRange(new object[] {
            "Gerente",
            "Especialista",
            "Técnico"});
            this.cmbBoxNivelDeAcesso.Location = new System.Drawing.Point(14, 343);
            this.cmbBoxNivelDeAcesso.Name = "cmbBoxNivelDeAcesso";
            this.cmbBoxNivelDeAcesso.Size = new System.Drawing.Size(157, 21);
            this.cmbBoxNivelDeAcesso.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Os campos com * são obrigatórios.";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(448, 382);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(105, 41);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Confirmar Senha*";
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Location = new System.Drawing.Point(356, 288);
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.Size = new System.Drawing.Size(197, 20);
            this.txtConfirmaSenha.TabIndex = 16;
            // 
            // frmGestaoFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 481);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "frmGestaoFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de  Funcionários";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mskBoxCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNivelDeAcesso;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxNivelDeAcesso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.Label label3;
    }
}