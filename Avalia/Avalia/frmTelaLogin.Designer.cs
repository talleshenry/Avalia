namespace Avalia
{
    partial class frmTelaLogin
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblomenteNumeros = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(157, 178);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(99, 32);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(23, 47);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(42, 18);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(23, 113);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(57, 18);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(26, 69);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(230, 20);
            this.tbCPF.TabIndex = 4;
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(26, 134);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(230, 20);
            this.tbSenha.TabIndex = 5;
            this.tbSenha.UseSystemPasswordChar = true;
            // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.Color.Transparent;
            this.btnLogar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.Location = new System.Drawing.Point(26, 178);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(101, 32);
            this.btnLogar.TabIndex = 0;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = false;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(191, 244);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(101, 16);
            this.lblMensagem.TabIndex = 7;
            this.lblMensagem.Text = "Seja Bem vindo!";
            // 
            // lblomenteNumeros
            // 
            this.lblomenteNumeros.AutoSize = true;
            this.lblomenteNumeros.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblomenteNumeros.Location = new System.Drawing.Point(60, 51);
            this.lblomenteNumeros.Name = "lblomenteNumeros";
            this.lblomenteNumeros.Size = new System.Drawing.Size(103, 14);
            this.lblomenteNumeros.TabIndex = 8;
            this.lblomenteNumeros.Text = "(Somente Números)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Avalia.Properties.Resources.right_1528483_640;
            this.pictureBox1.Location = new System.Drawing.Point(306, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmTelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(496, 269);
            this.Controls.Add(this.lblomenteNumeros);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnLogar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Login";
            this.Load += new System.EventHandler(this.frmTelaLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblomenteNumeros;
    }
}