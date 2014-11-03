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
            frmNewEmployee novoEmpregadoForm = new frmNewEmployee();
            novoEmpregadoForm.MdiParent = this;

            novoEmpregadoForm.Show();
            
            novoEmpregadoForm.WindowState = FormWindowState.Maximized;

        }
    }
}
