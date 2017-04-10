using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avalia
{
    public partial class frmGestaoFuncionarios : Form
    {
        public frmGestaoFuncionarios()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNome.Text == "" || txtEmail.Text == "" || mskBoxCpf.Text== "" || txtSenha.Text =="" || cmbBoxNivelDeAcesso.Text =="" ) {

                    MessageBox.Show("Preencha todos os campos obrigatórios!");


                }





            }
            catch (Exception)
            {

                throw;
            }





        }
    }
}
