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
            stUsuario.Text = "Usuario: " + LogInfo.userID + " ("+LogInfo.perfil+")";
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

        private void cadastroDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchase novaCompraForm = new frmPurchase();
            novaCompraForm.MdiParent = this;
            novaCompraForm.Show();

            novaCompraForm.WindowState = FormWindowState.Maximized;
        }

        private void gerenciarFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMngEmployees gerenciarFuncionarioForm = new frmMngEmployees();
            gerenciarFuncionarioForm.MdiParent = this;
            gerenciarFuncionarioForm.Show();

            gerenciarFuncionarioForm.WindowState = FormWindowState.Maximized;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void itensEmEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStockReport itensEmEstoqueForm = new frmStockReport();
            itensEmEstoqueForm.MdiParent = this;
            itensEmEstoqueForm.Show();

            itensEmEstoqueForm.WindowState = FormWindowState.Maximized;
        }
    }
}
