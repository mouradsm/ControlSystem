using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

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
                funcionario novoFuncionario = new funcionario();
                endereco novoEndereco = new endereco();

                var funcionario = from f in db.funcionario
                              where f.cpf == txtCPF.Text
                              select f;

                if (funcionario.Count() > 0)
                    throw new ApplicationException("CPF ou CNPJ já cadastrado!");

                novoEndereco.endereco1 = txtEndereco.Text;
                novoEndereco.bairro = txtBairro.Text;
                novoEndereco.cep = Int32.Parse(txtCEP.Text.Replace("-", ""));
                novoEndereco.cidade = txtCidade.Text;
                novoEndereco.UF = cboUF.SelectedText;
                novoEndereco.complemento = txtComplemento.Text;

                novoFuncionario.endereco = novoEndereco;
                novoFuncionario.cpf = txtCPF.Text;                
                novoFuncionario.email = txtEmail.Text;
                novoFuncionario.cargo = "";
                novoFuncionario.nome = txtNome.Text;
                novoFuncionario.status = cboStatus.SelectedText;
                novoFuncionario.telefone = txtTelefone.Text;

                db.endereco.Add(novoEndereco);
                db.funcionario.Add(novoFuncionario);
                db.SaveChanges();

                Form.ClearForm(this);

                MessageBox.Show("Cadastro efetuado com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboStatus.SelectedIndex) { 
                case 0:
                    string promptValue = Prompt.ShowDialog("Digite o Motivo da Inatividade", "Motivo da Inatividade");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtNome.Text, "^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ ]+$"))
            {
                errorProvider1.SetError(txtNome, "Nome Inválido!");
                e.Cancel = true;
                return;
            }

            // Name is Valid
            errorProvider1.SetError(txtNome, "");
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
    }
}
