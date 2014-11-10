using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSystem
{
    public partial class mainContainer : Form
    {
        public mainContainer()
        {
            InitializeComponent();
        }

        private void novoFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewCous novoClienteForm = new frmNewCous();
            novoClienteForm.MdiParent = this;

            novoClienteForm.Show();
            
            novoClienteForm.WindowState = FormWindowState.Maximized;

        }

        private void mainContainer_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void mainContainer_Load(object sender, EventArgs e)
        {
            stUsuario.Text = "Usuario: " + LogInfo.userID + " (PERFIL DE ACESSO)";
        }

        private void novoFuncionárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNewEmployee novoFuncionarioForm = new frmNewEmployee();
            novoFuncionarioForm.MdiParent = this;
            novoFuncionarioForm.Show();

            novoFuncionarioForm.WindowState = FormWindowState.Maximized;
        }

        private void cadastroDoEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewStock novoEstoqueForm = new frmNewStock();
            novoEstoqueForm.MdiParent = this;
            novoEstoqueForm.Show();

            novoEstoqueForm.WindowState = FormWindowState.Maximized;
        }

        private void cadastroDeFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewSupplier novoFornecedorForm = new frmNewSupplier();
            novoFornecedorForm.MdiParent = this;
            novoFornecedorForm.Show();

            novoFornecedorForm.WindowState = FormWindowState.Maximized;
        }
    }
}
