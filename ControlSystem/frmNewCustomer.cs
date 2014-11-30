using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

                var cliente = from c in db.cliente
                              where c.cpf == txtCPF.Text
                              || c.cnpj == txtCPF.Text
                              select c;

                if (cliente.Count() > 0)
                    throw new ApplicationException("CPF ou CNPJ já cadastrado!");

                novoEndereco.endereco1 = txtEndereco.Text;
                novoEndereco.bairro = txtBairro.Text;
                novoEndereco.cep = Int32.Parse(txtCEP.Text.Replace("-", ""));
                novoEndereco.cidade = txtCidade.Text;
                novoEndereco.UF = cboUF.SelectedText;
                novoEndereco.complemento = txtComplemento.Text;

                novoCliente.endereco = novoEndereco;

                if (cboTipo.SelectedIndex == 0)
                    novoCliente.cpf = txtCPF.Text;
                else
                    novoCliente.cnpj = txtCPF.Text;

                novoCliente.dateDeCadastramento = DateTime.Now;
                novoCliente.dataDeNascimento = DateTime.Parse(txtNascimento.Text);
                novoCliente.email = txtEmail.Text;

                novoCliente.nome = txtNome.Text;
                novoCliente.status = 1;
                novoCliente.telefone = txtTelefone.Text.Trim();

                db.endereco.Add(novoEndereco);
                db.cliente.Add(novoCliente);
                db.SaveChanges();

                MessageBox.Show("Cliente cadastardo com Sucesso!");

                Form.ClearForm(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTipo.SelectedIndex)
            {
                case 0:
                    lblCPF.Text = "CPF";
                    txtCPF.Mask = "000,000,000-00";
                    break;
                case 1:
                    lblCPF.Text = "CNPJ";
                    txtCPF.Mask = "00000000/0000-00";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void txtNascimento_Validating(object sender, CancelEventArgs e)
        {

            if (!Form.validarCampos((MaskedTextBox)sender))
            {
                errorProvider1.SetError(txtNascimento, "Nascimento é obrigatório");
                e.Cancel = true;
                return;
            }
            else
            {
                DateTime data = DateTime.Parse(txtNascimento.Text);

                if (DateTime.Now.Year - data.Year < 18)
                {
                    errorProvider1.SetError(txtNascimento, "Cliente deve ser maior de idade!");
                    e.Cancel = true;
                    return;
                }

            }
            errorProvider1.SetError(txtNascimento, "");

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!Form.validarCampos((TextBox)sender))
            {
                errorProvider1.SetError(txtEmail, "Email é obrigatório");
                e.Cancel = true;
                return;
            }
            else if (!Regex.IsMatch(txtEmail.Text, "^[_a-z0-9-]+(\\.[_a-z0-9-]+)*@[a-z0-9-]+(\\.[a-z0-9-]+)*(\\.[a-z]{2,4})$"))
            {
                errorProvider1.SetError(txtEmail, "Email Inválido!");
                e.Cancel = true;
                return;
            }

            errorProvider1.SetError(txtEmail, "");
        }
    }
}
