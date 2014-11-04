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
        cscEntities db;

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
                db = new cscEntities();
                funcionário novoFuncionario = new funcionário();

                novoFuncionario.bairro = txtBairro.Text;
                novoFuncionario.cep = Int32.Parse(txtCEP.Text.Replace("-", ""));
                novoFuncionario.cidade = txtCidade.Text;
                //novoFuncionario.cpf = txtCPF.Text;
                
                novoFuncionario.email = txtEmail.Text;
                novoFuncionario.endereco = txtEndereco.Text;
                novoFuncionario.nome = txtNome.Text;
                novoFuncionario.status = cboStatus.SelectedText;
                novoFuncionario.telefone = txtTelefone.Text;
                novoFuncionario.uf = cboUF.SelectedText;

                db.funcionário.Add(novoFuncionario);
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
