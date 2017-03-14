using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avalia.Model;

namespace Avalia
{
    public partial class frmPainelControle : Form
    {
        private int childFormNumber = 0;

        public frmPainelControle()
        {
            
            InitializeComponent();
            lbUsuario.Text = UsuarioLogado.getUsuarioLogado().Nome;
            lbCPF.Text = UsuarioLogado.getUsuarioLogado().Cpf;

            if (UsuarioLogado.getUsuarioLogado().NivelDeAcesso == 1)
            {
                btOrdemServico.Visible = true;
            }
            else if (UsuarioLogado.getUsuarioLogado().NivelDeAcesso == 2)
            {
                btOrdemServico.Visible = true;
                btGestaoAvaliacoes.Visible = true;
            }
            else if(UsuarioLogado.getUsuarioLogado().NivelDeAcesso == 3)
            {
                btOrdemServico.Visible = true;
                btGestaoAvaliacoes.Visible = true;
                btGestaoFuncionarios.Visible = true;
                btGestaoQuestoes.Visible = true;
            }

        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btOrdemServico_Click(object sender, EventArgs e)
        {
            frmOrdemServico objServico = new frmOrdemServico();
            objServico.MdiParent = this;
            objServico.Show();

        }

        private void btGestaoAvaliacoes_Click(object sender, EventArgs e)
        {
            frmGestaoAvaliacao objAvaliacoes = new frmGestaoAvaliacao();
            objAvaliacoes.MdiParent = this;
            objAvaliacoes.Show();
        }

        private void btGestaoQuestoes_Click(object sender, EventArgs e)
        {
            frmGestaoQuestoes objQuestoes = new frmGestaoQuestoes();
            objQuestoes.MdiParent = this;
            objQuestoes.Show();
        }

        private void btGestaoFuncionarios_Click(object sender, EventArgs e)
        {
            frmGestaoFuncionarios objFuncionarios = new frmGestaoFuncionarios();
            objFuncionarios.MdiParent = this;
            objFuncionarios.Show();
        }
        
        
    }
}
