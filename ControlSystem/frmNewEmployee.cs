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
    public partial class frmNewEmployee : Form
    {
        controlsystemEntities db;

        public frmNewEmployee()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmNewEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db = new controlsystemEntities();
                funcionario novoFuncionario = new funcionario();
                endereco novoEndereco = new endereco();

                novoEndereco.endereco1 = txtEndereco.Text;
                novoEndereco.bairro = txtBairro.Text;
                novoEndereco.cep = Int32.Parse(txtCEP.Text.Replace("-", ""));
                novoEndereco.cidade = txtCidade.Text;
                novoEndereco.UF = cboUF.SelectedText;

                novoFuncionario.endereco = novoEndereco;
                novoFuncionario.cpf = txtCPF.Text;                
                novoFuncionario.email = txtEmail.Text;

                novoFuncionario.nome = txtNome.Text;
                novoFuncionario.status = cboStatus.SelectedText;
                novoFuncionario.telefone = txtTelefone.Text;

                db.endereco.Add(novoEndereco);
                db.funcionario.Add(novoFuncionario);
                db.SaveChanges();

                Form.ClearForm(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
