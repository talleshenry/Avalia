using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avalia.DTO;
using Avalia.Model;

namespace Avalia
{

    /**
     * as cores que estão usando são
     
         */
    public partial class frmTelaLogin : Form
    {
        public frmTelaLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {

                if (tbCPF.Text == "")
                {
                    MessageBox.Show("O campo CPF Não pode estar vazio.");
                    tbSenha.Focus();
                    return;
                }

                if (tbSenha.Text == "")
                {
                    MessageBox.Show("O campo senha não pode estar vazio.");
                    btnLogar.Focus();
                    return;
                }

                UsuarioDTO objUsuario = new UsuarioDTO();

                objUsuario.Cpf = tbCPF.Text;
                objUsuario.Senha = tbSenha.Text;

                objUsuario = new UsuarioModel().AutenticacaoUsuario(objUsuario);

                if (objUsuario.Cpf == null)
                {
                    lblMensagem.Text = "usuário ou senha inválida";
                    lblMensagem.ForeColor = Color.Red;
                    return;
                }

                frmPainelControle painel = new frmPainelControle();

                this.Hide();
                painel.ShowDialog();
                Application.Exit();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro ao autenticar o usuário, ", ex.Message);
            }


        }

        private void frmTelaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
