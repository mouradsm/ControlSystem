using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSystem
{
    public partial class frmNewCous : Form
    {
        cscEntities db;

        public frmNewCous()
        {
            InitializeComponent();
        }

        private void frmNewEmployee_Load(object sender, EventArgs e)
        {
            db = new cscEntities();
            cboUF.DataSource = db.estados.ToList();
            cboUF.DisplayMember = "sigla";
            cboUF.ValueMember = "sigla";
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                db = new cscEntities();
                cliente novoCliente = new cliente();

                novoCliente.bairro = txtBairro.Text;
                novoCliente.cep = Int32.Parse(txtCEP.Text.Replace("-", ""));
                novoCliente.cidade = txtCidade.Text;
                novoCliente.cpf = txtCPF.Text;
                novoCliente.dataDeCadastramento = DateTime.Now;
                novoCliente.dataDeNascimento = DateTime.Parse(txtNascimento.Text);
                novoCliente.email = txtEmail.Text;
                novoCliente.endereco = txtEndereco.Text;
                novoCliente.nome = txtNome.Text;
                novoCliente.status = cboStatus.SelectedText;
                novoCliente.telefone = txtTelefone.Text;
                novoCliente.tipo = cboTipo.SelectedText;
                novoCliente.uf = cboUF.SelectedText;

                db.cliente.Add(novoCliente);
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
