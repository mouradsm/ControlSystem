using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSystem
{
    public partial class frmNewSupplier : Form
    {
        controlsystemEntities db;
        public frmNewSupplier()
        {
            InitializeComponent();
        }

        private void frmNewSupplier_Load(object sender, EventArgs e)
        {
            db = new controlsystemEntities();
            cboUF.DataSource = db.estados.ToList();
            cboUF.DisplayMember = "sigla";
            cboUF.ValueMember = "sigla";
        }

        //SALVAR    
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                db = new controlsystemEntities();


                var fornecedor = from f in db.fornecedor
                                  where f.cnpj == txtCNPJ.Text
                                  select f;

                if (fornecedor.Count() > 0)
                    throw new ApplicationException("CPF ou CNPJ já cadastrado!");

                fornecedor novoFornecedor = new fornecedor();
                novoFornecedor.cnpj = txtCNPJ.Text;
                novoFornecedor.dataDeCadastramento = DateTime.Now;
                novoFornecedor.email = txtEmail.Text;
                novoFornecedor.emailContato = txtEmailContato.Text;

                endereco novoEndereco = new endereco();

                novoEndereco.bairro = txtBairro.Text;
                novoEndereco.cep = Int32.Parse(txtCEP.Text.Replace("-", ""));
                novoEndereco.cidade = txtCidade.Text;
                novoEndereco.complemento = txtComplemento.Text;
                novoEndereco.UF = cboUF.SelectedText;

                db.endereco.Add(novoEndereco);

                novoFornecedor.endereco = novoEndereco;
                novoFornecedor.razaoSocial = txtRazaoSocial.Text;
                novoFornecedor.status = 1;
                novoFornecedor.telefone = txtTelefone.Text;
                novoFornecedor.telefoneContato = txtTelefoneContato.Text;

                db.fornecedor.Add(novoFornecedor);

                db.SaveChanges();

                Form.ClearForm(this);
                MessageBox.Show("Fornecedor cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void txtEmailContato_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtEmailContato.Text, "^[_a-z0-9-]+(\\.[_a-z0-9-]+)*@[a-z0-9-]+(\\.[a-z0-9-]+)*(\\.[a-z]{2,4})$"))
            {
                errorProvider1.SetError(txtEmailContato, "Email Inválido!");
                e.Cancel = true;
                return;
            }

            errorProvider1.SetError(txtEmailContato, "");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtEmail.Text, "^[_a-z0-9-]+(\\.[_a-z0-9-]+)*@[a-z0-9-]+(\\.[a-z0-9-]+)*(\\.[a-z]{2,4})$"))
            {
                errorProvider1.SetError(txtEmail, "Email Inválido!");
                e.Cancel = true;
                return;
            }

            errorProvider1.SetError(txtEmail, "");
        }

        private void txtNomeFantasia_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtNomeFantasia.Text, "^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ ]+$"))
            {
                errorProvider1.SetError(txtNomeFantasia, "Nome Inválido!");
                e.Cancel = true;
                return;
            }

            // Name is Valid
            errorProvider1.SetError(txtNomeFantasia, "");
        }

        private void txtNomeContato_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtNomeContato.Text, "^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ ]+$"))
            {
                errorProvider1.SetError(txtNomeContato, "Nome Inválido!");
                e.Cancel = true;
                return;
            }

            // Name is Valid
            errorProvider1.SetError(txtNomeContato, "");
        }
    }
}
