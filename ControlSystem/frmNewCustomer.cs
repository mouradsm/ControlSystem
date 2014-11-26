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
        controlsystemEntities db;

        public frmNewCous()
        {
            InitializeComponent();
        }

        private void frmNewEmployee_Load(object sender, EventArgs e)
        {
            db = new controlsystemEntities();
            cboUF.DataSource = db.estados.ToList();
            cboUF.DisplayMember = "sigla";
            cboUF.ValueMember = "sigla";
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                db = new controlsystemEntities();
                cliente novoCliente = new cliente();
                endereco novoEndereco = new endereco();

                novoEndereco.endereco1 = txtEndereco.Text;
                novoEndereco.bairro = txtBairro.Text;
                novoEndereco.cep = Int32.Parse(txtCEP.Text.Replace("-", ""));
                novoEndereco.cidade = txtCidade.Text;
                novoEndereco.UF = cboUF.SelectedText;
                novoEndereco.complemento = txtComplemento.Text;

                novoCliente.endereco = novoEndereco;
                novoCliente.cpf = txtCPF.Text;
                novoCliente.dateDeCadastramento = DateTime.Now;
                novoCliente.dataDeNascimento = DateTime.Parse(txtNascimento.Text);
                novoCliente.email = txtEmail.Text;
                
                novoCliente.nome = txtNome.Text;
                novoCliente.status = cboStatus.SelectedIndex;
                novoCliente.telefone = txtTelefone.Text.Trim();

                db.endereco.Add(novoEndereco);
                db.cliente.Add(novoCliente);
                db.SaveChanges();

                Form.ClearForm(this);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTipo.SelectedIndex) { 
                case 0:
                    break;
                case 1:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }
    }
}
